using InheritanceDemo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Daire : YuvarlakSekil, IHesapla
    {
        public double AlanHesapla()
        {
            return YariCap * YariCap * PI;
        }

        public double CevreHesapla()
        {
            return 2 * PI * YariCap;
        }
    }
}
