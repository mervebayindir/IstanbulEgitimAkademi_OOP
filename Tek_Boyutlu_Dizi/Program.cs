using Tek_Boyutlu_Dizi_Demo.Classes;

namespace Tek_Boyutlu_Dizi_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekBoyutluDizi dizi = new TekBoyutluDizi()
            {
                Dizi = new double[5]
                {
                    5.5,
                    1.1,
                    9.9,
                    3.3,
                    7.7
                },
            };
            dizi.Goster(" ");
            Console.Write(" dizinin elamanlarıdır.");
            Console.WriteLine("\nEleman sayısı: " + dizi.Boyut);
            Console.WriteLine("Eleman toplamı: " + dizi.Toplam);
            Console.WriteLine("Elaman ortalaması(Method): " + dizi.OrtalamaHesapla());
            Console.WriteLine("Elaman ortalaması: " + dizi.Ortalama);
            Console.WriteLine("Min eleman: " + dizi.MinimumGetir());
            Console.WriteLine("Max eleman: " + dizi.MaximumGetir());



        }
    }
}