using System.Globalization;

namespace Cagil_Hoca_Odev_Elektronik_Esya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Marka = "Hp",
                Model = "Probook 450 G9",
                SeriNo = 123456,
                UretimTarihi = DateTime.Parse("08.09.2022", new CultureInfo("tr-TR")),
                BilgisayarTipi = BilgisayarTipi.Dizüstü,
                IslemciTipi = IslemciTipi.i9,
                Hafıza = 16,
                EkranBoyutu = 15,
                SuSogutmaliMi = true,
            };


            Bilgisayar bilgisayar2 = new Bilgisayar();
            bilgisayar2.Marka = "Hp";
            bilgisayar2.Model = "Probook 450 G9";
            bilgisayar2.SeriNo = 123456;
            bilgisayar2.UretimTarihi = DateTime.Parse("08.09.2022", new CultureInfo("tr-TR"));
            bilgisayar2.BilgisayarTipi = BilgisayarTipi.Dizüstü;
            bilgisayar2.IslemciTipi = IslemciTipi.i9;
            bilgisayar2.Hafıza = 16;
            bilgisayar2.EkranBoyutu = 15;
            bilgisayar2.SuSogutmaliMi = true;

            Console.WriteLine(bilgisayar2.ToString());
        }
    }
}