using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSU_OOP
{
    public partial class Form2 : Form
    {
        Abone gonderilecekAbone = new Abone();
        public Form2(Abone aboneForm2)
        {
            InitializeComponent();
            TxtAboneNo.Text = aboneForm2.AboneNo;
            TxtAdSoyad.Text = aboneForm2.AdSoyad;
            TxtOncekiSayac.Text = aboneForm2.OncekiSayac.ToString();
            TxtSonSayac.Text = aboneForm2.SonSayac.ToString();
            TxtGuncelBorc.Text = aboneForm2.GuncelBorc.ToString();

            gonderilecekAbone = aboneForm2;
        }

        private void BtnOde_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ödeme Tutarı: " + gonderilecekAbone.GuncelBorc + "\nÖdeme Yapmak İstiyor Musunu?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                gonderilecekAbone.ToplamOdeme += gonderilecekAbone.GuncelBorc;
                gonderilecekAbone.odemeList.Add(gonderilecekAbone.GuncelBorc);
                gonderilecekAbone.GuncelBorc = 0;
                Form1 frm = new Form1(gonderilecekAbone);
                frm.Show();
                this.Hide();
            }
            
            
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
