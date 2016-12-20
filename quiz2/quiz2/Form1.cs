using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Abone> AboneListesi = new List<Abone>();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Abone abone = new Abone();
            abone.AboneAdı = TxtAboneAdı.Text;
            abone.AboneTipi = RbEv.Checked == false ? true : false;
            abone.oncekiİndex = int.Parse(TxtOnceki.Text);
            abone.sonrakiİndex = int.Parse(TxtSonraki.Text);

            AboneListesi.Clear();
            
            
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
