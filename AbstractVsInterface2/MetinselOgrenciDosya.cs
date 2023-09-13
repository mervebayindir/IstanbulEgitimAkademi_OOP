using AbstractVsInterface2.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface2
{
    public class MetinselOgrenciDosya : OgrenciDosyaBase
    {
        public override void OgrenciEkle(string ogrenci)
        {
            File.AppendAllText(DosyaYolu, "\n" + ogrenci, Encoding.UTF8);
        }

        public override string OgrencileriGetir()
        {
            string ogrenciler = "";
            File.ReadAllLines(DosyaYolu, Encoding.UTF8);
            string[] satirlar=File.ReadAllLines(DosyaYolu,Encoding.UTF8);
            foreach(string satir in satirlar) 
            {
                ogrenciler += satir + "\n";
            }
            ogrenciler.TrimEnd('\n');
            return ogrenciler;
        }
    }
}
