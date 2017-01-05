using Ev_Yemekleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_Yemekleri.Models
{
    class Menü
    {
        public List<AnaYemek> anaYemekler { get; set; }
        public List<Salata> salatalar { get; set; }
        public List<Tatlı> tatlılar { get; set; }
    }
}
