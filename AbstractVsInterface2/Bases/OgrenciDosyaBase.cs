using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface2.Bases
{
    public abstract class OgrenciDosyaBase
    {
        public string DosyaYolu { get; set; }
        public abstract string OgrencileriGetir();
        public abstract void OgrenciEkle(string ogrenci);
        public string DosyaAdiGetir()
        {
            return Path.GetFileName(DosyaYolu).Split('.')[0];
        }
        public string DosyaUzantisiGetir()
        {
            return Path.GetExtension(DosyaYolu).Substring(1).ToLower();              
        }
    }
}
