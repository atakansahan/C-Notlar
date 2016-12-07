using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWord_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Merhaba Canım");
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ad:" + AdTxtb.Text + "\nŞifre:" + SifreTxtb.Text);
        }
    }
}
