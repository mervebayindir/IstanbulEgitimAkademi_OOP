using AbstractVsInterface2.Bases;

namespace AbstractVsInterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciDosyaBase ogrenciDosya = new MetinselOgrenciDosya()
            {
                DosyaYolu = "../../../Dosyalar/Öğrenciler.txt"
            };
            Console.WriteLine(ogrenciDosya.DosyaAdiGetir());
            Console.WriteLine(ogrenciDosya.DosyaUzantisiGetir());
        }
    }
}