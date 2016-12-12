using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rocket.Visible = false;
            
        }
        int genislik, yukseklik;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    SpaceShip.Left -= 10;
                    break;
                case Keys.Right:
                    SpaceShip.Left += 10;
                    break;
                case Keys.Up:
                    SpaceShip.Top -= 10;
                    break;
                case Keys.Down:
                    SpaceShip.Top += 10;
                    break;

                case Keys.Space:
                    int x = SpaceShip.Location.X + SpaceShip.Width / 2;
                    int y = SpaceShip.Location.Y + SpaceShip.Height / 2;
                    Rocket.Location = new Point(x, y);
                    Rocket.Visible = true;
                    timer1.Start();
                    break;

                default:
                    break;

                
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            genislik = Form1.ActiveForm.Width;
            yukseklik = Form1.ActiveForm.Height;
            Rocket.Left += 10;
        }
    }
}
