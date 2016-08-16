namespace Steganograph
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Open = new System.Windows.Forms.Button();
            this.Coding = new System.Windows.Forms.Button();
            this.Decoding = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Textinfo = new System.Windows.Forms.TextBox();
            this.labelinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(16, 369);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(76, 29);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Coding
            // 
            this.Coding.Location = new System.Drawing.Point(191, 369);
            this.Coding.Name = "Coding";
            this.Coding.Size = new System.Drawing.Size(76, 29);
            this.Coding.TabIndex = 1;
            this.Coding.Text = "Coding";
            this.Coding.UseVisualStyleBackColor = true;
            this.Coding.Click += new System.EventHandler(this.Coding_Click);
            // 
            // Decoding
            // 
            this.Decoding.Location = new System.Drawing.Point(359, 369);
            this.Decoding.Name = "Decoding";
            this.Decoding.Size = new System.Drawing.Size(76, 29);
            this.Decoding.TabIndex = 2;
            this.Decoding.Text = "Decoding";
            this.Decoding.UseVisualStyleBackColor = true;
            this.Decoding.Click += new System.EventHandler(this.Decoding_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Location = new System.Drawing.Point(16, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(514, 350);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сообщение для кодирования";
            // 
            // Textinfo
            // 
            this.Textinfo.Location = new System.Drawing.Point(218, 427);
            this.Textinfo.Name = "Textinfo";
            this.Textinfo.Size = new System.Drawing.Size(312, 20);
            this.Textinfo.TabIndex = 6;
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo.Location = new System.Drawing.Point(13, 407);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(306, 17);
            this.labelinfo.TabIndex = 7;
            this.labelinfo.Text = "В данное изоброжение можно закодировать:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.Textinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Decoding);
            this.Controls.Add(this.Coding);
            this.Controls.Add(this.Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стеганография";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Coding;
        private System.Windows.Forms.Button Decoding;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Textinfo;
        private System.Windows.Forms.Label labelinfo;
    }
}

