using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari_OPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SskNo.Enabled = true;
        }

        private void LstBoxCalisan_DoubleClick(object sender, EventArgs e)
        {
            StaticTemsilcisi st = (StaticTemsilcisi)
                LstBoxCalisan.SelectedItem;

            comboMax.Enabled = false;
            Maas.Enabled = false;
            SskNo.Enabled = false;
            SatısAdeti.Enabled = true;
            button2.Enabled = true;

            SskNo.Value = st.sskNo;
            Maas.Value = Convert.ToDecimal(st.maas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticTemsilcisi st = new StaticTemsilcisi();
            st.elemanTuru = comboMax.SelectedItem.ToString();
            st.maas = Convert.ToDouble(Maas.Value);
            st.sskNo = Convert.ToInt32(SskNo.Value);

            LstBoxCalisan.Items.Add(st);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
