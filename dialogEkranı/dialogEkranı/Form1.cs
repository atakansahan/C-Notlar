using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogEkranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Silmek istiyormusunuz?", "Onay Ekranı", MessageBoxButtons.YesNoCancel);

            //if (result == DialogResult.Yes)
            //{
            //    Btn1.Text += "Evet";
            //}
            //else if (result == DialogResult.No)
            //{
            //    Btn1.Text = "Hayır";
            //}
            //else
            //{
            //    Btn1.Text = "İptal";
            //}
            if (TxtAdı.Text != "")
            {
                listBox.Items.Add(TxtAdı.Text);
            }
            TxtAdı.Clear();
            TxtAdı.Focus();
            TxtAdı.ForeColor = Color.Blue;
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçtiğiniz kişi listeden silinsin mi?", "Onay Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tümü silisin mi", "Onay Ekranı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                listBox.Items.Clear();
            }
        }
    }
}
