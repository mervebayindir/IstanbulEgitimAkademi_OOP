using InterfaceSegregation.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Calisan : ICalis, ICalisan  // Calisan bir ICalisan'dır (is a)
    {
        public void Calis()
        {
            Console.WriteLine("Çalışan çalışıyor.");
        }

        public void MaasAl()
        {
            Console.WriteLine("Çalışan maaş alıyor.");
        }

        public void YemekYe()
        {
            Console.WriteLine("Çalışan yemek yer.");
        }
    }
}
