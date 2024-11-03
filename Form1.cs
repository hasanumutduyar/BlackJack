namespace BlackJack
{
    public partial class Form1 : Form
    {
        List<int> deste = new List<int>();//kart numarasýný tutacak (0 - 51)
        enum KartTuru { Kupa = 0, Karo = 1, Sinek = 2, Maca = 3 };
        //her bir türde 13 kart var
        int siradakiOyuncu = 0; // 2 oyuncu var (0-1)
        int oyuncuSayi1 = 0;
        int oyuncuSayi2 = 0;

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
                int rastgele = rnd.Next(0, deste.Count);
                int kart = deste[rastgele];
                deste.RemoveAt(rastgele);// kartý desteden çýkar
                deste.Add((int) kart);//kartý destenin sonuna ekle
            }

            lblDesteKartSayisi.Text = deste.Count.ToString();

            pbDeste.Image = Properties.Resources.KartArka;

            pnlOyuncu1.Controls.Clear();
            pnlOyuncu2.Controls.Clear();

            oyuncuSayi1 = 0;
            oyuncuSayi2 = 0;

            lblOyuncu1Sayi.Text = oyuncuSayi1.ToString();
            lblOyuncu2Sayi.Text = oyuncuSayi2.ToString();

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


            SiradakiOyuncuyuDegistir(1);
        }

        private void btnKartCek2_Click(object sender, EventArgs e)
        {
            int sayi = KartCek(pnlOyuncu2);
            oyuncuSayi2 += sayi;

            lblOyuncu2Sayi.Text = oyuncuSayi2.ToString();
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
            string resAdi = $"{tur}{sira+1}";


            //caliþma zamaný kontrol oluþtur
            PictureBox pb = new PictureBox();
            pb.Size = new Size(103, 140);
            
            pb.Location = new Point(5 + pnl.Controls.Count*25, 5);

            pb.Image = (Image)Properties.Resources.ResourceManager.GetObject(resAdi);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            pnl.Controls.Add(pb);

            pb.BringToFront();

            return sira + 1;
        }
    }
}
