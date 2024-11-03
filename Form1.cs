namespace BlackJack
{
    public partial class Form1 : Form
    {
        List<int> deste = new List<int>();//kart numarasýný tutacak (0 - 51)
        List<Skor> skorlar = new List<Skor>();
        enum KartTuru { Kupa = 0, Karo = 1, Sinek = 2, Maca = 3 };
        //her bir türde 13 kart var
        int siradakiOyuncu = 0; // 2 oyuncu var (0-1)
        int oyuncuSayi1 = 0;
        int oyuncuSayi2 = 0;
        int pas1 = 0;
        int pas2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            deste.Clear();
            for (int i = 0; i < 52; i++)//tüm kartlarý desteye ekle
            {
                deste.Add(i);
            }


            Random rnd = new Random();

            for (int k = 0; k < 3; k++)
                for (int i = 0; i < deste.Count; i++)
                {
                    int rasgele = rnd.Next(0, deste.Count);//indeks
                    int kart = deste[rasgele];
                    deste.RemoveAt(rasgele);//kartý desteden çýkar
                    deste.Add((int)kart);//kartý destenin sonuna ekle
                }

            lblDesteKartSayisi.Text = deste.Count.ToString();

            pbDeste.Image = Properties.Resources.KartArka;

            pnlOyuncu1.Controls.Clear();
            pnlOyuncu2.Controls.Clear();

            oyuncuSayi1 = 0;
            oyuncuSayi2 = 0;
            pas1 = 0;
            pas2 = 0;

            lblOyuncu1Sayi.Text = oyuncuSayi1.ToString();
            lblOyuncu2Sayi.Text = oyuncuSayi2.ToString();

            lblKazanan.Visible = false;

            SiradakiOyuncuyuDegistir(0);
        }

        void SiradakiOyuncuyuDegistir(int sira)
        {
            siradakiOyuncu = sira;


            if (siradakiOyuncu == 0)
            {
                lblOyuncu1.BackColor = Color.Red;
                lblOyuncu1.ForeColor = Color.White;
                pnlOyuncu1Butonlar.Enabled = true;
                lblOyuncu2.BackColor = Color.FromArgb(192, 255, 192);
                lblOyuncu2.ForeColor = Color.Black;
                pnlOyuncu2Butonlar.Enabled = false;
            }
            else
            {
                lblOyuncu2.BackColor = Color.Red;
                lblOyuncu2.ForeColor = Color.White;
                pnlOyuncu2Butonlar.Enabled = true;
                lblOyuncu1.BackColor = Color.FromArgb(192, 255, 192);
                lblOyuncu1.ForeColor = Color.Black;
                pnlOyuncu1Butonlar.Enabled = false;
            }
        }

        private void btnKartCek1_Click(object sender, EventArgs e)
        {
            int sayi = KartCek(pnlOyuncu1);
            oyuncuSayi1 += sayi;

            lblOyuncu1Sayi.Text = oyuncuSayi1.ToString();

            pas1 = 0;

            if (!OyunBittiMiKontrolEt())
                SiradakiOyuncuyuDegistir(1);
        }

        private void btnKartCek2_Click(object sender, EventArgs e)
        {
            int sayi = KartCek(pnlOyuncu2);
            oyuncuSayi2 += sayi;

            lblOyuncu2Sayi.Text = oyuncuSayi2.ToString();
            pas2 = 0;

            if (!OyunBittiMiKontrolEt())
                SiradakiOyuncuyuDegistir(0);
        }

        int KartCek(Panel pnl)
        {

            int kart = deste[0];

            deste.RemoveAt(0);//0.indeksten sil
            lblDesteKartSayisi.Text = deste.Count.ToString();

            int sira = kart % 13;
            int grup = kart / 13;

            KartTuru tur = (KartTuru)grup;
            string resAdi = $"{tur}{sira + 1}";


            //caliþma zamaný kontrol oluþtur
            PictureBox pb = new PictureBox();
            pb.Size = new Size(103, 140);

            pb.Location = new Point(5 + pnl.Controls.Count * 25, 5);

            pb.Image = (Image)Properties.Resources.ResourceManager.GetObject(resAdi);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            pnl.Controls.Add(pb);

            pb.BringToFront();

            return sira + 1;
        }

        private void btnPas1_Click(object sender, EventArgs e)
        {
            pas1++;

            if (!OyunBittiMiKontrolEt())
                SiradakiOyuncuyuDegistir(1);
        }

        private void btnPas2_Click(object sender, EventArgs e)
        {
            pas2++;

            if (!OyunBittiMiKontrolEt())
                SiradakiOyuncuyuDegistir(0);
        }

        bool OyunBittiMiKontrolEt()
        {
            bool durum = false;
            int kazanan = 0;

            if (oyuncuSayi1 > 21) { kazanan = 1; durum = true; }
            else if (oyuncuSayi2 > 21) { kazanan = 0; durum = true; }


            else if (oyuncuSayi1 == 21) { kazanan = 0; durum = true; }
            else if (oyuncuSayi2 == 21) { kazanan = 1; durum = true; }

            else if (pas1 == 2 && pas2 == 2)
            {
                if (oyuncuSayi1 > oyuncuSayi2)
                    kazanan = 0;
                else if (oyuncuSayi1 < oyuncuSayi2)
                    kazanan = 1;
                else
                    kazanan = 2;//Beraberlik

                durum = true;

            }

            if (durum)
                OyunBitti(kazanan);

            return durum;
        }
        void OyunBitti(int kazanan)
        {
            lblOyuncu1.BackColor = Color.FromArgb(192, 255, 192);
            lblOyuncu1.ForeColor = Color.Black;
            pnlOyuncu1Butonlar.Enabled = false;

            lblOyuncu2.BackColor = Color.FromArgb(192, 255, 192);
            lblOyuncu2.ForeColor = Color.Black;
            pnlOyuncu2Butonlar.Enabled = false;

            lblKazanan.Text = "KAZANAN";

            if (kazanan == 0)
            {

                lblKazanan.Location = new Point(lblOyuncu1.Left + (lblOyuncu1.Width - lblKazanan.Width) / 2, lblOyuncu1.Top - lblKazanan.Height - 10);
            }
            else if (kazanan == 1)
            {
                lblKazanan.Location = new Point(lblOyuncu2.Left + (lblOyuncu2.Width - lblKazanan.Width) / 2, lblOyuncu2.Top - lblKazanan.Height - 10);

            }
            else
            {
                lblKazanan.Text = "BERABERE";
                lblKazanan.Location = new Point((Width - lblKazanan.Width) / 2, lblOyuncu2.Top - lblKazanan.Height - 10);

            }

            pbDeste.Image = null;
            lblDesteKartSayisi.Text = "0";
            deste.Clear();


            lblKazanan.Visible = true;

            Skor s = new Skor() { Oyuncu1Puan = oyuncuSayi1, Oyuncu2Puan = oyuncuSayi2 };
            skorlar.Add(s);
        }
        private void btnSkorlar_Click(object sender, EventArgs e)
        {
            FrmSkorlar form = new FrmSkorlar(skorlar);
            form.ShowDialog();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel2.Location = new Point((Width - panel2.Width) / 2, panel2.Top);
        }
    }
}

