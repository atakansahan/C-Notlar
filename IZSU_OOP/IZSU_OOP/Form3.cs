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
    public partial class Form3 : Form
    {
        Abone _abone = new Abone();
        public Form3(Abone gelenAbone, int index)
        {
            InitializeComponent();
            TxtAboneNo.Text = gelenAbone.AboneNo;
            TxtAdSoyad.Text = gelenAbone.AdSoyad;
            TxtOdenenMiktar.Text = gelenAbone.odemeList[index].ToString()   ;
            TxtToplamOdeme.Text = gelenAbone.ToplamOdeme.ToString();
            _abone = gelenAbone;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
