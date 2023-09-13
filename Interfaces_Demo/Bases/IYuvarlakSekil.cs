using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Demo.Bases
{
    internal interface IYuvarlakSekil
    {
        double Yaricap { get; }
        bool PiUcMu { get; }

        double AlanHesapla();
        double CevreHesapla();
    }
}
