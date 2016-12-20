using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    class Abone
    {
        public string AboneAdı;
        public bool AboneTipi;
        public int oncekiİndex;
        public int sonrakiİndex;
        public override string ToString()
        {
            return this.AboneAdı + "\t" + this.AboneTipi + "\t" + this.oncekiİndex + "\t" + this.sonrakiİndex ;
        }
    }
}
