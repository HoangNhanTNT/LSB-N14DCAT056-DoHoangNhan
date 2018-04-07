namespace Steganography
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessager = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(464, 355);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(78, 29);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open Image";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(193, 360);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(265, 20);
            this.textBoxImage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Messager";
            // 
            // textBoxMessager
            // 
            this.textBoxMessager.Location = new System.Drawing.Point(193, 410);
            this.textBoxMessager.Name = "textBoxMessager";
            this.textBoxMessager.Size = new System.Drawing.Size(265, 20);
            this.textBoxMessager.TabIndex = 4;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(193, 451);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(100, 30);
            this.buttonEncode.TabIndex = 5;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(346, 451);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(100, 30);
            this.buttonDecode.TabIndex = 6;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textBoxMessager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImage);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessager;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Label label2;
    }
}

