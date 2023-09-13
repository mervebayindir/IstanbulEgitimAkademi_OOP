using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Bases
{
    public class Dikdortgen : KoseliSekil, IHesapla
    {
        public double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
        public double CevreHesapla()
        {
            return 2 * (Genislik + Yukseklik);
        }
    }
}
