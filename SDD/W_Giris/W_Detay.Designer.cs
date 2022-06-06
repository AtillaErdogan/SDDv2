namespace W_Giris
{
    partial class W_Detay
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
            this.txt_Ad = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.Label();
            this.txt_Cinsiyet = new System.Windows.Forms.Label();
            this.txt_Belgeler = new System.Windows.Forms.Label();
            this.txt_AdDeger = new System.Windows.Forms.Label();
            this.txt_SoyadDeger = new System.Windows.Forms.Label();
            this.txt_CinsiyetDeger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Ad
            // 
            this.txt_Ad.AutoSize = true;
            this.txt_Ad.Location = new System.Drawing.Point(22, 34);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(31, 15);
            this.txt_Ad.TabIndex = 0;
            this.txt_Ad.Text = "Ad : ";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.AutoSize = true;
            this.txt_Soyad.Location = new System.Drawing.Point(22, 79);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(48, 15);
            this.txt_Soyad.TabIndex = 1;
            this.txt_Soyad.Text = "Soyad : ";
            // 
            // txt_Cinsiyet
            // 
            this.txt_Cinsiyet.AutoSize = true;
            this.txt_Cinsiyet.Location = new System.Drawing.Point(22, 127);
            this.txt_Cinsiyet.Name = "txt_Cinsiyet";
            this.txt_Cinsiyet.Size = new System.Drawing.Size(55, 15);
            this.txt_Cinsiyet.TabIndex = 2;
            this.txt_Cinsiyet.Text = "Cinsiyet :";
            // 
            // txt_Belgeler
            // 
            this.txt_Belgeler.AutoSize = true;
            this.txt_Belgeler.Location = new System.Drawing.Point(22, 172);
            this.txt_Belgeler.Name = "txt_Belgeler";
            this.txt_Belgeler.Size = new System.Drawing.Size(55, 15);
            this.txt_Belgeler.TabIndex = 3;
            this.txt_Belgeler.Text = "Belgeler :";
            // 
            // txt_AdDeger
            // 
            this.txt_AdDeger.AutoSize = true;
            this.txt_AdDeger.Location = new System.Drawing.Point(126, 34);
            this.txt_AdDeger.Name = "txt_AdDeger";
            this.txt_AdDeger.Size = new System.Drawing.Size(31, 15);
            this.txt_AdDeger.TabIndex = 4;
            this.txt_AdDeger.Text = "Ad : ";
            // 
            // txt_SoyadDeger
            // 
            this.txt_SoyadDeger.AutoSize = true;
            this.txt_SoyadDeger.Location = new System.Drawing.Point(126, 79);
            this.txt_SoyadDeger.Name = "txt_SoyadDeger";
            this.txt_SoyadDeger.Size = new System.Drawing.Size(31, 15);
            this.txt_SoyadDeger.TabIndex = 5;
            this.txt_SoyadDeger.Text = "Ad : ";
            // 
            // txt_CinsiyetDeger
            // 
            this.txt_CinsiyetDeger.AutoSize = true;
            this.txt_CinsiyetDeger.Location = new System.Drawing.Point(126, 127);
            this.txt_CinsiyetDeger.Name = "txt_CinsiyetDeger";
            this.txt_CinsiyetDeger.Size = new System.Drawing.Size(31, 15);
            this.txt_CinsiyetDeger.TabIndex = 6;
            this.txt_CinsiyetDeger.Text = "Ad : ";
            // 
            // W_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_CinsiyetDeger);
            this.Controls.Add(this.txt_SoyadDeger);
            this.Controls.Add(this.txt_AdDeger);
            this.Controls.Add(this.txt_Belgeler);
            this.Controls.Add(this.txt_Cinsiyet);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Name = "W_Detay";
            this.Text = "W_Detay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_Ad;
        private System.Windows.Forms.Label txt_Soyad;
        private System.Windows.Forms.Label txt_Cinsiyet;
        private System.Windows.Forms.Label txt_Belgeler;
        private System.Windows.Forms.Label txt_AdDeger;
        private System.Windows.Forms.Label txt_SoyadDeger;
        private System.Windows.Forms.Label txt_CinsiyetDeger;
    }
}