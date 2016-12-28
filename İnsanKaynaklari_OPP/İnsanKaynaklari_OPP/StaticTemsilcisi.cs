using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari_OPP
{
    class StaticTemsilcisi : Calisan
    {
        public int satisMiktarı { get; set; }

        public override double ZamYap(int satis)
        {
            if (satis <= 10)
            {
                maas += satis * 10;
            }
            else if (satis <= 20)
            {
                maas += satis * 20;
            }
            else
            {
                maas += satis * 30;
            }
            return maas;
        }
    }
}
