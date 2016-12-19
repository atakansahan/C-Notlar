using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBilet
{
    public partial class YolcuForm : Form
    {
        public YolcuForm()
        {
            InitializeComponent();            
        }
        private void kaydetBTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk No: " + KoltukNoTBOX.Text +" - Ad soyad :"+ adSoyadTBOX.Text);
            listBox1.Refresh();
            System.Threading.Thread.Sleep(800);
            this.Hide();
        }
    }
}
