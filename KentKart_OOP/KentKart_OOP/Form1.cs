using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OgrenciKart ogrenci = new OgrenciKart();
        OgretmenKart ogretmen = new OgretmenKart();
        Kart tam = new Kart();
        int kartid = 1;

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (RbOgrenci.Checked == true)
            {
                ogrenci.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogrenci.KartID = kartid;
                kartid++;
                ogrenci.kartTuru = yolcuTipi.Ogrenci;
                ogrenci.okulAdi = TxtOkulAdı.Text;
                LstBox.Items.Add(ogrenci);
            }
            else if(RbOgretmen.Checked == true)
            {
                ogretmen.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogretmen.KartID = kartid;
                kartid++;
                ogretmen.kartTuru = yolcuTipi.Ogrenci;
                LstBox.Items.Add(ogretmen);
            }
            else
            {
                tam.bakiye = Convert.ToDouble(TxtBakiye.Text);
                tam.KartID = kartid;
                tam.kartTuru = yolcuTipi.Tam;
                kartid++;
                LstBox.Items.Add(tam);
            }
        }

        private void RbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            GbOkulAdı.Enabled = RbOgrenci.Checked == true ? true : false;
        }

        private void LstBox_DoubleClick(object sender, EventArgs e)
        {
            Kart yolcu = (Kart)LstBox.SelectedItem;
            
            {
                if (yolcu.kartTuru == yolcuTipi.Ogrenci && (yolcu.bakiye - 1 >= 0))
                {
                    LstBox.Items.RemoveAt(LstBox.SelectedIndex);
                    ogrenci = (OgrenciKart)yolcu;
                    ogrenci.Okut();
                    LstBox.Items.Add(ogrenci);
                }
                else if (yolcu.kartTuru == yolcuTipi.Ogretmen && (yolcu.bakiye - 2 >= 0))
                {
                    LstBox.Items.RemoveAt(LstBox.SelectedIndex);
                    ogretmen = (OgretmenKart)yolcu;
                    ogretmen.Okut();
                    LstBox.Items.Add(ogretmen);
                }
                else if (yolcu.kartTuru == yolcuTipi.Tam && (yolcu.bakiye - 3 >= 0))
                {
                    LstBox.Items.RemoveAt(LstBox.SelectedIndex);
                    tam = (Kart)yolcu;
                    tam.Okut();
                    LstBox.Items.Add(tam);
                }
                else
                {
                    MessageBox.Show("Bakiye Yetersiz");
                }
            }
        }

        private void Temizle()
        {
            TxtBakiye.Clear();
            TxtOkulAdı.Clear();
        }
    }
}
