using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Demo_2.Classes
{
    public class Ogrenci
    {
        const decimal Vize1Carpan = 0.2m;
        const decimal Vize2Carpan = 0.2m;
        const decimal FinalCarpan = 0.6m;
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Vize1 { get; set; }
        public decimal Vize2 { get; set; }
        public decimal Final { get; set; }
        public decimal Ortalama => Vize1Carpan * Vize1 + Vize2Carpan * Vize2 + FinalCarpan * Final;
        public decimal OrtalamaHesapla() => Vize1Carpan * Vize1 + Vize2Carpan * Vize2 + FinalCarpan * Final;
        public Durumlar Durum
        {
            get
            {
                if (Ortalama >= 60)
                    return Durumlar.Geçti;
                return Durumlar.Kaldı;
            }
        }
        public Ogrenci(string adi, string soyadi, decimal vize1, decimal vize2, decimal final)
        {
            Adi = adi;
            Soyadi = soyadi;
            Vize1 = vize1;
            Vize2 = vize2;
            Final = final;
        }
        public Ogrenci()
        {

        }


    }
}
