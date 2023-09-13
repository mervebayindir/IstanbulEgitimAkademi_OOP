using InterfaceSegregation.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Yonetici : ICalis, ICalisan
    {
        public void Calis()
        {
            Console.WriteLine("Yönetici çalışıyor.");
        }

        public void MaasAl()
        {
            Console.WriteLine("Yönetici maaş alıyor.");
        }

        public void YemekYe()
        {
            Console.WriteLine("Yönetici yemek yiyor.");
        }
    }
}
