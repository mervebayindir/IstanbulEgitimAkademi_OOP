using Interfaces_Demo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Demo
{
    public class Daire:IYuvarlakSekil
    {
        /*
         Dare daire= new Daire(3);
        Dare daire= new Daire(4, false);
         */
        public double Yaricap { get; }
        public bool PiUcMu { get; }

        public double Pi { get; }

        public Daire(double yariCap, bool piUcMu = true)
        {
            Yaricap = yariCap;
            PiUcMu = piUcMu;
            Pi = PiUcMu ? 3 : Math.PI;
        }

        public double AlanHesapla()
        {
            return Pi * Math.Pow(Yaricap, 2);
        }
        public double CevreHesapla()
        {
            return 2 * Pi * Yaricap;
        }
    }
}
