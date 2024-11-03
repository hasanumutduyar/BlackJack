namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblDesteKartSayisi = new Label();
            pbDeste = new PictureBox();
            pnlOyuncu1 = new Panel();
            pnlOyuncu1Butonlar = new Panel();
            btnPas1 = new Button();
            btnKartCek1 = new Button();
            lblOyuncu1 = new Label();
            lblOyuncu1Sayi = new Label();
            lblOyuncu2Sayi = new Label();
            lblOyuncu2 = new Label();
            pnlOyuncu2Butonlar = new Panel();
            btnPas2 = new Button();
            btnKartCek2 = new Button();
            pnlOyuncu2 = new Panel();
            btnSkorlar = new Button();
            btnBaslat = new Button();
            lblKazanan = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeste).BeginInit();
            pnlOyuncu1Butonlar.SuspendLayout();
            pnlOyuncu2Butonlar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDesteKartSayisi);
            panel1.Controls.Add(pbDeste);
            panel1.Location = new Point(478, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 194);
            panel1.TabIndex = 0;
            // 
            // lblDesteKartSayisi
            // 
            lblDesteKartSayisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDesteKartSayisi.ForeColor = Color.White;
            lblDesteKartSayisi.Location = new Point(15, 142);
            lblDesteKartSayisi.Name = "lblDesteKartSayisi";
            lblDesteKartSayisi.Size = new Size(103, 25);
            lblDesteKartSayisi.TabIndex = 1;
            lblDesteKartSayisi.Text = "0";
            lblDesteKartSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbDeste
            // 
            pbDeste.Location = new Point(15, -1);
            pbDeste.Name = "pbDeste";
            pbDeste.Size = new Size(103, 140);
            pbDeste.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeste.TabIndex = 0;
            pbDeste.TabStop = false;
            // 
            // pnlOyuncu1
            // 
            pnlOyuncu1.BorderStyle = BorderStyle.FixedSingle;
            pnlOyuncu1.Location = new Point(82, 326);
            pnlOyuncu1.Name = "pnlOyuncu1";
            pnlOyuncu1.Size = new Size(390, 170);
            pnlOyuncu1.TabIndex = 1;
            // 
            // pnlOyuncu1Butonlar
            // 
            pnlOyuncu1Butonlar.Controls.Add(btnPas1);
            pnlOyuncu1Butonlar.Controls.Add(btnKartCek1);
            pnlOyuncu1Butonlar.Enabled = false;
            pnlOyuncu1Butonlar.Location = new Point(82, 502);
            pnlOyuncu1Butonlar.Name = "pnlOyuncu1Butonlar";
            pnlOyuncu1Butonlar.Size = new Size(390, 48);
            pnlOyuncu1Butonlar.TabIndex = 2;
            // 
            // btnPas1
            // 
            btnPas1.Location = new Point(130, 10);
            btnPas1.Name = "btnPas1";
            btnPas1.Size = new Size(94, 29);
            btnPas1.TabIndex = 0;
            btnPas1.Text = "Pas";
            btnPas1.UseVisualStyleBackColor = true;
            btnPas1.Click += btnPas1_Click;
            // 
            // btnKartCek1
            // 
            btnKartCek1.Location = new Point(30, 10);
            btnKartCek1.Name = "btnKartCek1";
            btnKartCek1.Size = new Size(94, 29);
            btnKartCek1.TabIndex = 0;
            btnKartCek1.Text = "Kart Çek";
            btnKartCek1.UseVisualStyleBackColor = true;
            btnKartCek1.Click += btnKartCek1_Click;
            // 
            // lblOyuncu1
            // 
            lblOyuncu1.BackColor = Color.FromArgb(192, 255, 192);
            lblOyuncu1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOyuncu1.Location = new Point(85, 286);
            lblOyuncu1.Name = "lblOyuncu1";
            lblOyuncu1.Size = new Size(387, 33);
            lblOyuncu1.TabIndex = 3;
            lblOyuncu1.Text = "OYUNCU1";
            // 
            // lblOyuncu1Sayi
            // 
            lblOyuncu1Sayi.AutoSize = true;
            lblOyuncu1Sayi.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblOyuncu1Sayi.ForeColor = Color.White;
            lblOyuncu1Sayi.Location = new Point(24, 372);
            lblOyuncu1Sayi.Name = "lblOyuncu1Sayi";
            lblOyuncu1Sayi.Size = new Size(40, 46);
            lblOyuncu1Sayi.TabIndex = 4;
            lblOyuncu1Sayi.Text = "0";
            // 
            // lblOyuncu2Sayi
            // 
            lblOyuncu2Sayi.AutoSize = true;
            lblOyuncu2Sayi.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblOyuncu2Sayi.ForeColor = Color.White;
            lblOyuncu2Sayi.Location = new Point(1031, 372);
            lblOyuncu2Sayi.Name = "lblOyuncu2Sayi";
            lblOyuncu2Sayi.Size = new Size(40, 46);
            lblOyuncu2Sayi.TabIndex = 8;
            lblOyuncu2Sayi.Text = "0";
            // 
            // lblOyuncu2
            // 
            lblOyuncu2.BackColor = Color.FromArgb(192, 255, 192);
            lblOyuncu2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOyuncu2.Location = new Point(624, 286);
            lblOyuncu2.Name = "lblOyuncu2";
            lblOyuncu2.Size = new Size(387, 33);
            lblOyuncu2.TabIndex = 7;
            lblOyuncu2.Text = "OYUNCU2";
            // 
            // pnlOyuncu2Butonlar
            // 
            pnlOyuncu2Butonlar.Controls.Add(btnPas2);
            pnlOyuncu2Butonlar.Controls.Add(btnKartCek2);
            pnlOyuncu2Butonlar.Enabled = false;
            pnlOyuncu2Butonlar.Location = new Point(621, 502);
            pnlOyuncu2Butonlar.Name = "pnlOyuncu2Butonlar";
            pnlOyuncu2Butonlar.Size = new Size(390, 48);
            pnlOyuncu2Butonlar.TabIndex = 6;
            // 
            // btnPas2
            // 
            btnPas2.Location = new Point(130, 10);
            btnPas2.Name = "btnPas2";
            btnPas2.Size = new Size(94, 29);
            btnPas2.TabIndex = 0;
            btnPas2.Text = "Pas";
            btnPas2.UseVisualStyleBackColor = true;
            btnPas2.Click += btnPas2_Click;
            // 
            // btnKartCek2
            // 
            btnKartCek2.Location = new Point(30, 10);
            btnKartCek2.Name = "btnKartCek2";
            btnKartCek2.Size = new Size(94, 29);
            btnKartCek2.TabIndex = 0;
            btnKartCek2.Text = "Kart Çek";
            btnKartCek2.UseVisualStyleBackColor = true;
            btnKartCek2.Click += btnKartCek2_Click;
            // 
            // pnlOyuncu2
            // 
            pnlOyuncu2.BorderStyle = BorderStyle.FixedSingle;
            pnlOyuncu2.Location = new Point(621, 326);
            pnlOyuncu2.Name = "pnlOyuncu2";
            pnlOyuncu2.Size = new Size(390, 170);
            pnlOyuncu2.TabIndex = 5;
            // 
            // btnSkorlar
            // 
            btnSkorlar.Font = new Font("Segoe UI", 12F);
            btnSkorlar.Location = new Point(900, 63);
            btnSkorlar.Name = "btnSkorlar";
            btnSkorlar.Size = new Size(171, 45);
            btnSkorlar.TabIndex = 9;
            btnSkorlar.Text = "Skorları Göster";
            btnSkorlar.UseVisualStyleBackColor = true;
            btnSkorlar.Click += btnSkorlar_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.Font = new Font("Segoe UI", 12F);
            btnBaslat.Location = new Point(61, 73);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(171, 45);
            btnBaslat.TabIndex = 9;
            btnBaslat.Text = "Oyunu Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // lblKazanan
            // 
            lblKazanan.BackColor = SystemColors.HighlightText;
            lblKazanan.Font = new Font("Segoe UI", 13F);
            lblKazanan.ForeColor = Color.Red;
            lblKazanan.Location = new Point(181, 225);
            lblKazanan.Name = "lblKazanan";
            lblKazanan.Size = new Size(125, 48);
            lblKazanan.TabIndex = 10;
            lblKazanan.Text = "KAZANAN";
            lblKazanan.TextAlign = ContentAlignment.MiddleCenter;
            lblKazanan.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBaslat);
            panel2.Controls.Add(lblKazanan);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pnlOyuncu1);
            panel2.Controls.Add(btnSkorlar);
            panel2.Controls.Add(pnlOyuncu1Butonlar);
            panel2.Controls.Add(lblOyuncu2Sayi);
            panel2.Controls.Add(lblOyuncu1);
            panel2.Controls.Add(lblOyuncu2);
            panel2.Controls.Add(lblOyuncu1Sayi);
            panel2.Controls.Add(pnlOyuncu2Butonlar);
            panel2.Controls.Add(pnlOyuncu2);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 597);
            panel2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Green;
            ClientSize = new Size(1105, 598);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "BlackJack";
            SizeChanged += Form1_SizeChanged;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDeste).EndInit();
            pnlOyuncu1Butonlar.ResumeLayout(false);
            pnlOyuncu2Butonlar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbDeste;
        private Label lblDesteKartSayisi;
        private Panel pnlOyuncu1;
        private Panel pnlOyuncu1Butonlar;
        private Button btnPas1;
        private Button btnKartCek1;
        private Label lblOyuncu1;
        private Label lblOyuncu1Sayi;
        private Label lblOyuncu2Sayi;
        private Label lblOyuncu2;
        private Panel pnlOyuncu2Butonlar;
        private Button btnPas2;
        private Button btnKartCek2;
        private Panel pnlOyuncu2;
        private Button btnSkorlar;
        private Button btnBaslat;
        private Label lblKazanan;
        private Panel panel2;
    }
}
