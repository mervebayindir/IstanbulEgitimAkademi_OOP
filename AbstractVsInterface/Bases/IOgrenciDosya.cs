using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface.Bases
{
    public interface IOgrenciDosya
    {
        string DosyaYolu { get; set; }
        string OgerncileriGetir();
        void OgrenciEkle(string ogrenci);
        string DosyaAdiGetir();
        string DosyaUzantisiGetir();
    }
}
