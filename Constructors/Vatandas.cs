using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Vatandas
    {
        //Console da Önce özellikler çalışıyor daha sonra Contructors çalışıyor
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; } = "Antalya";   // böylede atama yapılabılır
        int _yas;
        public bool ErkekMi { get; set; }
        public Vatandas() // Default constructors
        {
            Ulke = "Türkiye";
            Adi = "";
            Soyadi = "";
            Sehir = "";
            _yas = 0;
            ErkekMi = true;
        }
        public string TamAdi
        {
            get
            {
                return Adi + " " + Soyadi;
            }
        }
        public string UlkeVeSehirGetir()
        {
            return $"{Ulke} / {Sehir}";
        }
        public string Lkoasyon => Ulke + " / " + Sehir;

        

    }
}
