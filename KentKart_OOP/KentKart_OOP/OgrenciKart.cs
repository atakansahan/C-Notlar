using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart_OOP
{
    class OgrenciKart : Kart
    {
        public OgrenciKart()
        {

        }
        public string okulAdi { get; set; }

        public override void Okut()
        {
            MessageBox.Show("1 tl alındı. Kalan Bakiye: " + (bakiye - 1));
            bakiye--;   
        }

        public override string ToString()
        {
            return this.KartID + "\t" + this.bakiye + "\t" + this.okulAdi + "\t" + this.kartTuru;
        }
    }
}
