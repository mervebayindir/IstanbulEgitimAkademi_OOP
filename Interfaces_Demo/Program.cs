using Interfaces_Demo.Bases;

namespace Interfaces_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IYuvarlakSekil daire = new Daire(2);
            Console.WriteLine("Alan: " + daire.AlanHesapla());
            Console.WriteLine("Cevre: " + daire.CevreHesapla());

            Console.WriteLine("Pı: " + (daire as Daire).Pi); // (daire as Daire) casting 

            daire = new Daire(2, false);
            Console.WriteLine("Alan: " + daire.AlanHesapla());
            Console.WriteLine("Cevre: " + daire.CevreHesapla());

            //Dikdortgen sekil = new Dikdortgen()
            //{
            //    Genislik = 4,
            //    Yukseklik = 3,
            //};
            //Console.WriteLine("Alan: " + sekil.AlanHesapla());
            //Console.WriteLine("Cevre: " + sekil.CevreHesapla());


            IKoseliSekil sekil2 = new DikUcgen()
            {
                Genislik = 4,
                Yukseklik = 3,
            };
            Console.WriteLine("Alan: " + sekil2.AlanHesapla());
            Console.WriteLine("Cevre: " + sekil2.CevreHesapla());

            sekil2 = new Dikdortgen()
            {
                Genislik = 4,
                Yukseklik = 3,
            };
            Console.WriteLine("Alan: " + sekil2.AlanHesapla());
            Console.WriteLine("Cevre: " + sekil2.CevreHesapla());


            sekil2 = new Dikdortgen();
            sekil2.Yukseklik = 30;
            sekil2.Genislik = 40;
            Console.WriteLine("Alan: " + sekil2.AlanHesapla());
            Console.WriteLine("Cevre: " + sekil2.CevreHesapla());


        }
    }
}