using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FrmSkorlar : Form
    {
        List<Skor> skorlar;
        public FrmSkorlar(List<Skor> liste)
        {
            InitializeComponent();

            skorlar = liste;
            int el = 1;
            int puan1 = 0;
            int puan2 = 0;

            foreach (Skor skor in skorlar)
            {
                string satir = $"{el}.El ----> {skor.Oyuncu1Puan}            {skor.Oyuncu2Puan}";
                listBox1.Items.Add(satir);

                if (skor.Oyuncu1Puan == 21 ||
                    (skor.Oyuncu1Puan < skor.Oyuncu2Puan && skor.Oyuncu2Puan != 21)) puan1++;

                else if (skor.Oyuncu2Puan == 21 ||
                    (skor.Oyuncu2Puan < skor.Oyuncu1Puan && skor.Oyuncu1Puan != 21)) puan2++;

                el++;
            }

            lblPuan1.Text = puan1.ToString();
            lblPuan2.Text = puan2.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
