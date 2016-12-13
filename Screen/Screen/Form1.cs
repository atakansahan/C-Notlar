using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> isimler = new List<string>() {"asdasd","asdasdas" ,"asdasd","asdasd","asdasd","afsdgfns","gdfgdfg","asdasd","asdasd","asdasd","asdasd","sadasd","asdsad","asdasdas" };
        Random rnd = new Random();
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0, 14);
            string isim = isimler[index];

            Graphics g = CreateGraphics();

            Color color = RasgeleRenk();

            int red = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            int black = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);

            int x = rnd.Next(10, this.Width - 50);
            int y = rnd.Next(10, this.Height - 50);

            int fontSize = rnd.Next(20, 40);


            g.DrawString(isim, new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold), new SolidBrush(Color.FromArgb(red, blue, black, green)), x, y);

            if (sayac == 200)
            {
                this.Invalidate();
                sayac = 0;
            }
            sayac++;
        }
        private Color RasgeleRenk()
        {
            Color color;
            int red = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            int black = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);

            color = Color.FromArgb(red, blue, black, green);
            return color;
        }
    }
}
