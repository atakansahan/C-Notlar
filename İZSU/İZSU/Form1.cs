using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İZSU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abone _abone = new Abone();
            _abone.AboneNo = TxtAboneNo.Text;
            _abone.AdSoyad = TxtAdSoyad.Text;
            _abone.OncekiSayac = int.Parse(TxtOnceki.Text);
            _abone.SonSayac = int.Parse(TxtSonraki.Text);

            string aboneTuru = RbEv.Checked == true ? "Ev" : "Kurum";
            aboneTuru = RbSirket.Checked == true ? "Kurum" : "Ev";
            _abone.AboneTuru = aboneTuru;

            ListBoxÖdemeListesi.Items.Add(_abone);

        }

        private void ListBoxÖdemeListesi_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxÖdemeListesi.SelectedItem;
            double odeme = _abone.OdemeHesapla(_abone.OncekiSayac, _abone.SonSayac, _abone.SonOdeme, _abone.AboneTuru);

            DialogResult result = MessageBox.Show("Ödeme Tutarı: " + odeme + "\nÖdeme Yapmak İstermisiniz?", "Ödeme Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ListBoxÖdemeListesi.Items.Remove(_abone);
                ListBoxÖdenenler.Items.Add(_abone);
            }
        }

        private void ListBoxÖdenenler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxÖdenenler.SelectedItem;
            Form2 frm = new Form2(_abone);
            frm.Show();
            
        }
    }
}
