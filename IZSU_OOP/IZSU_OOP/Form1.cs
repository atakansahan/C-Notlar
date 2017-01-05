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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Abone gelenAbone)
        {
            InitializeComponent();

            if (gelenAbone.GuncelBorc == 0)
            {
                Odenenler.Add(gelenAbone);
            }
        }
        
        static List<Abone> Aboneler = new List<Abone>();
        static List<Abone> Odenenler = new List<Abone>();
        Abone _abone = new Abone();
        private void button1_Click(object sender, EventArgs e)
        {
            _abone.AboneNo = TxtAboneNo.Text;
            _abone.AdSoyad = TxtAdSoyad.Text;
            _abone.OncekiSayac = int.Parse(TxtOncekiSayac.Text);
            _abone.SonSayac = int.Parse(TxtSonSayac.Text);

            string aboneTuru = RadioBtnEv.Checked == true ? "Ev" : "Kurum";
            aboneTuru = RadioBtnKurum.Checked == true ? "Kurum" : "Ev";
            _abone.AboneTuru = aboneTuru;

            double odeme = _abone.OdemeHesapla(_abone.OncekiSayac, _abone.SonSayac, _abone.AboneTuru);
            _abone.GuncelBorc = odeme;

            var result = Aboneler.FirstOrDefault(x => x.AboneNo == _abone.AboneNo);

            if (result == null)
            {
                ListBoxAboneler.Items.Add(_abone);
                Aboneler.Add(_abone);
            }
            else
            {
                result.SonSayac = int.Parse(TxtSonSayac.Text);

                odeme = result.OdemeHesapla(result.OncekiSayac, result.SonSayac, result.AboneTuru);
                result.GuncelBorc = odeme;
            }
        }

        private void ListBoxAboneler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxAboneler.SelectedItem;
            
            
            Form2 frm = new Form2(_abone);
            frm.Show();
            this.Hide();
        }

        
        private void ListBoxOdenenler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxOdenenler.SelectedItem;
            int index = ListBoxOdenenler.SelectedIndex; 
            Form3 frm = new Form3(_abone, index);
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Aboneler)
            {
                ListBoxAboneler.Items.Add(item);
            }

            foreach (var item in Odenenler)
            {
                ListBoxOdenenler.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = Aboneler.FirstOrDefault(x => x.AboneNo == TxtAboneNo.Text);

            if (result != null)
            {
                TxtOncekiSayac.Enabled = false;
                TxtAdSoyad.Enabled = false;
                groupBox1.Enabled = false;
                TxtAboneNo.Enabled = false;

                result.OncekiSayac = result.SonSayac;
                TxtOncekiSayac.Text = result.SonSayac.ToString();
                TxtAdSoyad.Text = result.AdSoyad;

                RadioBtnEv.Checked = result.AboneTuru == "Ev" ? true : false;
                RadioBtnKurum.Checked = result.AboneTuru == "Kurum" ? true : false;
            }
        }
    }
}
