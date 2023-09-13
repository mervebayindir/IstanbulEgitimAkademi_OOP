using Interfaces_Demo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Demo
{
    internal class DikUcgen : IKoseliSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        //public double Hipotenus { get; set; }

        public double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + Genislik + Yukseklik;
        }
    }
}
