using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZarAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fincan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 7);
            zar_1.ImageLocation = System.IO.Path.GetFullPath("Resimler/6.gif");
            zar_2.ImageLocation = System.IO.Path.GetFullPath("Resimler/6.gif");
        }

        private void Fincan()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 7);
            zar_1.ImageLocation = System.IO.Path.GetFullPath("Resimler//" + sayi + ".gif");
            sayi = rnd.Next(1, 7);
            zar_1.ImageLocation = System.IO.Path.GetFullPath("Resimler//" + sayi + ".gif");
        }

        private void zar_1_Click(object sender, EventArgs e)
        {
            Fincan();
        }

        private void zar_2_Click(object sender, EventArgs e)
        {
            Fincan();
        }
    }
}
