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

namespace Günlük_Kur_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc;
        DateTime tarih;
        private void BtnGetir_Click(object sender, EventArgs e)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            DateTime tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            string AUD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='AUD']/BanknoteSelling").InnerXml;

            label1.Text = "Euro: " + tarih.ToString("dd/MM/yyyy") + " - " + EUR + " ₺";
            label2.Text = "DOLAR: " + tarih.ToString("dd/MM/yyyy") + " - " + USD + " ₺";
            label3.Text = "AUD: " + tarih.ToString("dd/MM/yyyy") + " - " + AUD + " ₺";

            dataGridView1.Rows.Add("Dolar", tarih.ToString("dd//MM/yy"), USD);
            dataGridView1.Rows.Add("EUR", tarih.ToString("dd//MM/yy"), EUR);
            dataGridView1.Rows.Add("AUD", tarih.ToString("dd//MM/yy"), AUD);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() =="USD")
            {
                string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Dolar", tarih.ToString("dd//MM/yy"), USD);
            }
            else if (comboBox1.SelectedItem.ToString() == "AUD")
            {
                string AUD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='AUD']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Aud", tarih.ToString("dd//MM/yy"), AUD);

            }
            else
            {
                string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Eur", tarih.ToString("dd//MM/yy"), EUR);
            }
        }
    }
}
