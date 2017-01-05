using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KafeSiparisEkranıAtakanSahan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            DateTime tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='AUD']/BanknoteSelling").InnerXml;

            LbDolar.Text = "Dolar: "+ EUR + " ₺";
            LbEuro.Text = "Euro: "+ USD + " ₺";
            LbPound.Text = "Pound: "+ GBP + " ₺";

            PMasa.Visible = false;
            int counter = 1;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 6; j++)
                {

                    Button btn = new Button();
                    btn.Click += Button_Click;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Text = counter + " ";
                    btn.Left = (btn.Width * j);
                    btn.Top = (btn.Height * i);
                    GBoxMasa.Controls.Add(btn);
                    counter++;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Add("Kuru Fasulye 5₺ :");
            comboBox1.Items.Add("Tavuklu Pilav 6₺ :");
            comboBox1.Items.Add("Simit Tost 4₺ :");
            comboBox1.Items.Add("Lazanya 2₺ :");

            comboBox2.Items.Add("Su 1₺ :");
            comboBox2.Items.Add("Kola 2₺ :");
            comboBox2.Items.Add("Limonata 3₺ :");
            comboBox2.Items.Add("Çay 1.5₺ :");
            comboBox2.Items.Add("Kahve 5₺ :");
            
            Siparis s = new Siparis();
            s.yemek = Convert.ToString(comboBox1.SelectedItem);
            s.içecek = Convert.ToString(comboBox2.SelectedItem);
            s.yemekadet = Convert.ToInt32(numericUpDown1.Value);
            s.icecekadet = Convert.ToInt32(numericUpDown2.Value);
            Button secilenmasa = sender as Button;
            LBMasaNo.Text = secilenmasa.Text;

            
            
        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem + "\t" + numericUpDown1.Value + " Adet");
                listBox1.Items.Add(comboBox2.SelectedItem + "\t " + numericUpDown2.Value + " Adet");
                
            }
            else if (listBox1.Items == null)
            {
                listBox1.Items.Remove(-1);
            }
        }
    }
}
