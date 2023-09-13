namespace Constructors_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci ogrenci = new Ogrenci()
            //{
            //    Adi = "Merve",
            //    Soyadi = "Bayındır",
            //};

            Ogrenci ogrenci2 = new Ogrenci("Zümra", "Bayındır", 100, 90, 100);
            ogrenci2.OrtalamaVeDurumHesapla();
            Console.WriteLine(ogrenci2.Getir());

            Ogrenci ogrenci3 = new Ogrenci("Zümra", "Bayındır");
            Console.WriteLine(ogrenci3.Getir());


            //DateTime dt = new DateTime();


        }
    }
}