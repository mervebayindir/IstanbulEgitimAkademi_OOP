using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Demo.Bases
{
    public interface IKoseliSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        double AlanHesapla();

        double CevreHesapla();
    }
}
