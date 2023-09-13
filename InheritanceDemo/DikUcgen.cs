using InheritanceDemo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class DikUcgen : KoseliSekil, IHesapla
    {
        public double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            return Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2)) + Genislik + Yukseklik;
        }
    }
}
