using Interfaces_Demo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Demo
{
    internal class Dikdortgen : IKoseliSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

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
