using Barbut.Classes;

namespace Barbut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zar zar;
            int sayi1;
            int sayi2;
            string yuz1, yuz2;
            


            #region
            //zar = new Zar();
            //Zar zar = new Zar();
            //int sayi1 = zar.At();
            //int sayi2 = zar.At();

            //if (sayi1 > sayi2)
            //    Console.WriteLine("1. zar ( " + sayi1 + " ) kazandı." + "  2. zar: " + sayi2);
            //else if (sayi1 < sayi2)
            //    Console.WriteLine("2. zar ( " + sayi2 + " ) kazandi." + "  2. zar: " + sayi1);
            //else
            //    Console.WriteLine("Berabere");
            #endregion

            #region do while ile yapımı

            //Zar zar1;
            //int s1;
            //int s2;
            string giris;
            //zar = new Zar();
            //do
            //{
            //    Console.WriteLine("Oynamak istermisin? e: evet, h: hayır");
            //    giris = Console.ReadLine();
            //    if (giris == "e" || giris == "E")
            //    {
            //        s1 = zar.At();
            //        s2 = zar.At();

            //        if (s1 > s2)
            //            Console.WriteLine("1. zar ( " + sayi1 + " ) kazandı." + "  2. zar: " + sayi2);
            //        else if (s1 < s2)
            //            Console.WriteLine("2. zar ( " + sayi2 + " ) kazandi." + "  2. zar: " + sayi1);
            //        else
            //            Console.WriteLine("Berabere");
            //    }

            //} while (giris == "e" || giris == "E");

            #endregion


            #region  while ile yapımı

            zar = new Zar();
            Console.WriteLine("Oynamak istermisin? e: evet, h: hayır");
            giris = Console.ReadLine();
            while (giris == "e" || giris == "E")
            {
                sayi1 = zar.At();
                yuz1 = zar.Yuz;
                sayi2 = zar.At();
                yuz2 = zar.Yuz;
                Console.WriteLine(sayi1 > sayi2 ? $"1. Sayı: {yuz1}\n" +
                    $"2. Sayı: {yuz2}\n" +
                    $"1. Zar kazandı." : sayi1 < sayi2 ? $"2. Sayı: {yuz2}\n" +
                    $"1. Sayı: {yuz1}\n" +
                    $"2. Zar kazandı." : "Berabere." + sayi1 + " == " + sayi2);
                Console.WriteLine("Oynamak ister misin? e: evet, h: hayır");
                giris = Console.ReadLine();
            }

            #endregion
        }
    }
}