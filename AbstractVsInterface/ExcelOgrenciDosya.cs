using AbstractVsInterface.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    public class ExcelOgrenciDosya:IOgrenciDosya
    {
        public string DosyaYolu { get; set; }

        public string DosyaAdiGetir()
        {
            string dosya = Path.GetFileName(DosyaYolu); // Öğrenciler.txt
            return dosya.Split(".")[0]; // Öğrenciler
        }

        public string DosyaUzantisiGetir()
        {
            string dosya = Path.GetExtension(DosyaYolu); // .TXT
            return dosya.Substring(1).ToLower(); // txt
        }

        public string OgerncileriGetir()
        {
            throw new NotImplementedException();
        }

        public void OgrenciEkle(string ogrenci)
        {
            throw new NotImplementedException();
        }
    }
}
