using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Steganograph
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private Bitmap MyImage;
        private void Open_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "BMP Files|*.bmp";
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            MyImage = new Bitmap(openFileDialog.FileName);
                            pictureBox.Image = (Image)MyImage;
                            labelinfo.Text = "В данное изоброжение можно закодировать символов:" + ((MyImage.Height * MyImage.Width)/1).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Coding_Click(object sender, EventArgs e)
        {
            string message = Textinfo.Text;
            // Пиксель изображения
            Color pixel;

            int x = 0;
           
            // Читаем сообщение*
            byte[] B = Encoding.GetEncoding(1251).GetBytes(message + '/');

            bool f = false;
            
            // Проходим по изображению
            for (int i = 0; i < MyImage.Width; i++)
            {
                if (f) break;

                for (int j = 0; j < MyImage.Height; j++)
                {
                    // Берем пиксель
                    pixel = MyImage.GetPixel(i, j);

                    // Если зашифровали все сообщение, выходим
                    if (x == B.Length) { f = true; break; }

                    // Представляем байт сообщения в виде массива бит (см. выше пример 11001100)
                    Bits m = new Bits(B[x++]);

                    // Дополняем до 8 бит
                    while (m.Length != 8) m.Insert(0, 0);

                    // Берем каждый цвет RGB и если нужно, дополняем до 8 бит
                    Bits r = new Bits(pixel.R); while (r.Length != 8) r.Insert(0, 0);
                    Bits g = new Bits(pixel.G); while (g.Length != 8) g.Insert(0, 0);
                    Bits b = new Bits(pixel.B); while (b.Length != 8) b.Insert(0, 0);

                    // Заменяем соответствующие младшие биты битами нашего сообщения
                    r[6] = m[0];
                    r[7] = m[1];

                    g[5] = m[2];
                    g[6] = m[3];
                    g[7] = m[4];

                    b[5] = m[5];
                    b[6] = m[6];
                    b[7] = m[7];

                    // Записываем пиксель обратно в изображение
                    MyImage.SetPixel(i, j, Color.FromArgb(r.Number, g.Number, b.Number));
                }
            }
            MyImage.Save("C:\\123change.bmp");
            Textinfo.Text = "";
            
        }

        private void Decoding_Click(object sender, EventArgs e)
        {
            // Пиксель изображения
            Color pixel;

            // Байты считываемого сообщения
            ArrayList array = new ArrayList();

            bool f = false;

            // Проходим по изображению
            for (int i = 0; i < MyImage.Width; i++)
            {
                if (f) break;

                for (int j = 0; j < MyImage.Height; j++)
                {
                    // Берем пиксель
                    pixel = MyImage.GetPixel(i, j);

                    // Текущий считываемый байт
                    Bits m = new Bits(255);

                    // Берем каждый цвет RGB и если нужно, дополняем до 8 бит
                    Bits r = new Bits(pixel.R); while (r.Length != 8) r.Insert(0, 0);
                    Bits g = new Bits(pixel.G); while (g.Length != 8) g.Insert(0, 0);
                    Bits b = new Bits(pixel.B); while (b.Length != 8) b.Insert(0, 0);

                    // Читаем младшие биты
                    m[0] = r[6];
                    m[1] = r[7];

                    m[2] = g[5];
                    m[3] = g[6];
                    m[4] = g[7];

                    m[5] = b[5];
                    m[6] = b[6];
                    m[7] = b[7];

                    // Если встретили наш спецсимвол, то достигли конца сообщения, выходим
                    if (m.Char == '/') { f = true; break; }

                    // Считываемый байт переводим в число
                    array.Add(m.Number);
                }
            }

            byte[] msg = new byte[array.Count];

            // Переводим сообщение в байты, т.к. мы получили сообщение в числовом представлении байта
            for (int i = 0; i < array.Count; i++)
                msg[i] = Convert.ToByte(array[i]);

            // А вот и наше сообщение
            Textinfo.Text = Encoding.GetEncoding(1251).GetString(msg);
        }
    }
}
