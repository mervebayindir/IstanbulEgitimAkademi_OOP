namespace AbstractClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YazilimDersi yazilimDersi = new YazilimDersi()
            {
                Adi = "C#",
                Id = 1,
                Sinav1Notu = 20,
                Sinav2Notu = 70,
                SonSinavNotu = 90
            };
            double not = yazilimDersi.DersNotuHesapla();
            int maximumNot = yazilimDersi.MaksimumNotGetir();
            Console.WriteLine($"Kodu: {yazilimDersi.KodGetir()}\nAdı: {yazilimDersi.Adi}\nNot: {not}/{maximumNot}");

            MuzikDersi muzikDersi = new MuzikDersi()
            {
                Id = 2,
                Adi = "Armoni",
                Sinav1Notu = 6,
                Sinav2Notu = 4
            };
            not=muzikDersi.DersNotuHesapla();
            maximumNot = muzikDersi.MaksimumNotGetir();
            Console.WriteLine($"Kodu: {muzikDersi.KodGetir()}\nAdı: {muzikDersi.Adi}\nNot: {not}/{maximumNot}");

        }
    }
}