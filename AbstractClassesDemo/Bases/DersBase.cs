using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo.Bases
{
    public abstract class DersBase
    {
        // abstract ve Interface arasındakı en buyuk fark abstract sınıflarda method tanımı yapıp methoda iş verebiliyoruz ınterfacede sadece method tanımı yapılır.
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Sinav1Notu { get; set; }
        public double Sinav2Notu { get; set; }
        public virtual double DersNotuHesapla() => Sinav1Notu * 0.5 + Sinav2Notu * 0.5;
        public virtual byte MaksimumNotGetir() => 100;

        public abstract string KodGetir();

    }
}
