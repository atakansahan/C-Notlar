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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        YolcuForm yform = new YolcuForm();
        public Button btn;

        private void otobusTipCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (otobusTipCMBOX.SelectedIndex.ToString() == "0")
            {
                int no = 0;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j != 2 && (i != 4 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Width = 60;
                            btn.Height = 60;
                            no++;
                            btn.Text = Convert.ToString(no);
                            btn.Left = (btn.Width) * (j);
                            btn.Top = (btn.Height) * (i);
                            btn.Click += Btn_click;
                            panel1.Controls.Add(btn);
                        }
                    }
                }
            }
            else if (otobusTipCMBOX.SelectedIndex.ToString() == "1")
            {
                int no = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j != 2 && (i != 3 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Width = 60;
                            btn.Height = 60;
                            no++;
                            btn.Text = Convert.ToString(no);
                            btn.Left = (btn.Width) * (j);
                            btn.Top = (btn.Height) * (i);
                            btn.Click += Btn_click;
                            panel1.Controls.Add(btn);
                        }
                    }

                }

            }

        }

        private void Btn_click(object sender, EventArgs v)
        {
            Button secbtn = sender as Button;
            yform.Show();
            secbtn.BackColor = Color.FromArgb(255, 70, 70);
            yform.KoltukNoTBOX.Text = secbtn.Text;
            yform.adSoyadTBOX.Text ="";
            secbtn.Enabled = false;
        }


    }
}
