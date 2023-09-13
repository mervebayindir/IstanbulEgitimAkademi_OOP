using AbstractVsInterface.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    public class MetinselOgrenciDosya : IOgrenciDosya
    {
        public string DosyaYolu { get; set; }

        public string DosyaAdiGetir()
        {
            string dosya = Path.GetFileName(DosyaYolu); // Öğrenciler.txt
            return dosya.Split(".")[0]; // Öğrenciler
        }

        public string DosyaUzantisiGetir()
        {
            string dosya=Path.GetExtension(DosyaYolu); // .TXT
            return dosya.Substring(1).ToLower(); // txt
        }

        public string OgerncileriGetir()
        {
            string ogrenciler = "";
            ogrenciler = File.ReadAllText(DosyaYolu, Encoding.UTF8);
            return ogrenciler;
        }

        public void OgrenciEkle(string ogrenci)
        {
            //File.WriteAllText(DosyaYolu, ogrenci, Encoding.UTF8);
            File.AppendAllText(DosyaYolu, "\n" + ogrenci, Encoding.UTF8);
        }
    }
}
