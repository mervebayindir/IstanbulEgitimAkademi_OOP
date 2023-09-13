namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FutbolTakimi futbolTakimi = new FutbolTakimi()
            {
                Adi = "Fenerbahçe",
                KurulusYili = 1907,
                Sehir = "İstanbul",

                TeknikDirektorAdi = "İsmail Kartal",
                DefansOyuncuAdlari = "Becao, Djiku, Ferdi, Osayi",
                OrtaSahaOyuncuAdlari = "Tadic, Symaski, Cengiz",
                ForvetOyuncuAdlari = "Dzeko, İrfan, Can, Fred",
                OyunSistemi = "4-3-3",
            };
            Console.WriteLine(futbolTakimi.BilgiGetir());
            Console.WriteLine(futbolTakimi.KadroGetir());

            Console.WriteLine("Oyun Sistemi: " + futbolTakimi.OyunSistemi);
            Console.WriteLine("Şehir: " + futbolTakimi.Sehir);

            Takim futbolTakimi2 = new Takim();
            futbolTakimi2.Sehir = "İstanbul";
            futbolTakimi2.KurulusYili = 1903;
            futbolTakimi2.Adi = "Beşiktaş";

            Console.WriteLine(futbolTakimi2.BilgiGetir());

            futbolTakimi2 = new FutbolTakimi()   // polymorphism
            {
                Adi = "Galatasaray",
                KurulusYili = 1905,
                Sehir="İstanbul",

                DefansOyuncuAdlari= "Leo, Abdulkerim, Victor, Sacha",
                OrtaSahaOyuncuAdlari="Berkan, Sergio, Milot, Barış",
                ForvetOyuncuAdlari="Muhammed, Dries",
                OyunSistemi="4-4-2",
                KaleciAdi="Muslera",
                TeknikDirektorAdi="Okan Buruk"
            };
            Console.WriteLine(futbolTakimi2.BilgiGetir());

            // casting
            FutbolTakimi futbolTakimi3 = (FutbolTakimi)futbolTakimi2;
            FutbolTakimi futbolTakimi4 = futbolTakimi2 as FutbolTakimi;

            Console.WriteLine(futbolTakimi3.KadroGetir());
            Console.WriteLine("Oyun Sistemi: " + futbolTakimi3.OyunSistemi);

            BasketbolTakimi basketbolTakimi = new BasketbolTakimi()
            {
                Adi = "Başiktaş",
                KurulusYili = 1903,
                Sehir="İstanbul",

                BasAntrenorAdi = "Igor",
                GeriSahaOyuncuAdlari = "Yağız, Allerik",
                OnSahaOyuncuAdlari = "David, Okben, Kerem",
            };
        }
    }
}