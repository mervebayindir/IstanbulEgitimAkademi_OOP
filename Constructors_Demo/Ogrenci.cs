using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Demo
{
    public class Ogrenci
    {
        const decimal VİZE1CARPAN = 0.2M;
        const decimal VİZE2CARPAN = 0.2M;
        const decimal FİNALCARPAN = 0.6M;

        decimal _vize1;
        decimal _vize2;
        decimal _final;
        decimal _ortalama;
        //string _durum = "Kaldı"
        string _durum;
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public Ogrenci(string adi, string soyadi, decimal vize1, decimal vize2, decimal final)
        {
            Adi = adi;
            Soyadi = soyadi;
            _vize1 = vize1;
            _vize2 = vize2;
            _final = final;
            _durum = "Kaldı";

        }
        public Ogrenci(string adi, string soyadi, string durum = "Devamsız")
        {
            Adi = adi;
            Soyadi = soyadi;
            _durum = durum;
        }
        public Ogrenci()
        {
            _durum = "Kaldı";
        }
        public void OrtalamaVeDurumHesapla()
        {
            _ortalama = VİZE1CARPAN * _vize1 + VİZE2CARPAN * _vize2 + FİNALCARPAN * _final;
            if (_ortalama >= 60)
                _durum = "Geçti";
        }
        public string Getir()
        {
            string sonuc = $"Öğrenci: {Adi} {Soyadi}";
            sonuc += $"\nNot ortalaması: {_ortalama.ToString("N1")}";
            sonuc += $"\nDurumu: \"{_durum}\"";
            return sonuc;
        }

    }
}
