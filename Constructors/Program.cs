namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas citizen = new Vatandas()   // new Vatandas() Default constructors
            {
                Adi = "Merve",
                Soyadi = "Bayındır",
                //Sehir = "Antalya",
            };
            Vatandas citizen2 = new Vatandas();
            citizen.Adi = "Kutluhan";
            citizen.Soyadi = "Bayındır";
            //citizen.Sehir = "Yozgat";

            Console.WriteLine("Adı: " + citizen.TamAdi + "\n" + "Lokoasyonu: " + citizen.UlkeVeSehirGetir());

            Vatandas citizen3 = new Vatandas();
            citizen3.ErkekMi = false;
            Console.WriteLine(citizen3.Adi.Trim());

        }
    }
}