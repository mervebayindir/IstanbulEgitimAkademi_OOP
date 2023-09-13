using Constructors_Demo_2.Classes;

namespace Constructors_Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci2 = new Ogrenci()
            {
                Adi = "Merve",
                Soyadi = "Bayındır",
                Vize1 = 100m,
                Vize2 = 72m,
                Final = 65m,
            };

            Console.WriteLine($"Tam adı: {ogrenci2.Adi} {ogrenci2.Soyadi}");
            Console.WriteLine($"Ortalama: {ogrenci2.Ortalama}");
            Console.WriteLine($"Durum: {ogrenci2.Durum}");

            Console.WriteLine("************************");

            Ogrenci ogrenci = new Ogrenci("Merve", "Bayındır", 25, 85, 40);
            Console.WriteLine("Tam adı: " + ogrenci.Adi + " " + ogrenci.Soyadi);
            Console.WriteLine("Ortalama: " + ogrenci.OrtalamaHesapla());
            Console.WriteLine("Durum: " + ogrenci.Durum);


        }
    }
}