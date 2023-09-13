using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Takim // base, parent, Concrete
    {
        public string Adi { get; set; }
        public short KurulusYili { get; set; }
        public string Sehir { get; set; }
        public string BilgiGetir()
        {
            return $"Takım: {Adi}\nKuruluş Yılı:{KurulusYili}";
        }
    }
}
