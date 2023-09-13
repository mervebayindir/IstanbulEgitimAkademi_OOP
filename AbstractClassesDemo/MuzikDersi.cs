using AbstractClassesDemo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo
{
    public class MuzikDersi : DersBase
    {
        public override string KodGetir()
        {
            return "MÜ-" + Id;
        }
        public override byte MaksimumNotGetir()
        {
            return 10;
        }
    }
}
