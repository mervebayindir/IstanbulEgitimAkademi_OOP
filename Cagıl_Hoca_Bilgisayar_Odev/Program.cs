using System.Globalization;
using System.Reflection;

namespace Cagıl_Hoca_Bilgisayar_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Id = 1,
                Marka = "Hp",
                Model = "Probook 450 G9",
                BilgisayarTipi = BilgisayarTipleri.Laptop,
                GHz = 4.700,
                Hafiza = 1,
                EkranBoyutu = 15,
                SuSogutmaliMi = true,
                UretimTarihi = new DateTime(2022, 07, 27)
            };

            Console.WriteLine($"Id: {bilgisayar.Id}");
            Console.WriteLine($"Marka: {bilgisayar.Marka}");
            Console.WriteLine($"Model: {bilgisayar.Model}");
            Console.WriteLine($"Bilgisayar Tipi: {bilgisayar.BilgisayarTipi}");
            Console.WriteLine($"Ghz: {bilgisayar.GHz.ToString("N1", new CultureInfo("tr-TR"))} GHz");
            Console.WriteLine($"Hafıza: {bilgisayar.Hafiza} Tb");
            Console.WriteLine($"Ekran Boyutu: {bilgisayar.EkranBoyutu}\"");
            Console.WriteLine("Su soğutma var mı: " + (bilgisayar.SuSogutmaliMi == true ? "Evet" : "Hayır."));
            Console.WriteLine($"Üretim tarihi: {bilgisayar.UretimTarihi.ToString("dd/MM/yyyy")}");

        }

    }
}