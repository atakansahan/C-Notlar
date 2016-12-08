using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeKadarKaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gunlukSaat = Convert.ToInt32(textBox1.Text);

            //int gunlukSaat = Convert.ToInt32(GunlukSaatTxtB.Text);

            //int gun = 10000 / gunlukSaat;
            //int ay = gun / 30;
            //int yıl = gun / 365;

            //MessageBox.Show("Gün : " + gun + "\nAy : " + ay + "\nYıl : " + yıl);

            if (gunlukSaat >24)
            {
                Mes
            }

        }
    }
}
