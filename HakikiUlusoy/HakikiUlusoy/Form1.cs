using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HakikiUlusoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Musteri> MusteriListesi = new List<Musteri>();
        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdSoyad = textBox1.Text;
            musteri.Cinsiyet = radioButton1.Checked == false ? true : false ;
            musteri.OtobusTuru = comboBox1.SelectedItem.ToString();

            MusteriListesi.Add(musteri);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
