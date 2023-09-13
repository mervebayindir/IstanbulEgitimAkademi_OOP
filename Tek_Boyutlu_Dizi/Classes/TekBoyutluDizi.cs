using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_Boyutlu_Dizi_Demo.Classes
{
    public class TekBoyutluDizi
    {
        //double[] _dizi; // field
        //public double[] Dizi
        //{
        //    get => _dizi;
        //    set => _dizi = value;
        //}
        public double[] Dizi { get; set; }
        public int Boyut => Dizi.Length;
        public void Goster(string ayrac = "\n")
        {
            Console.WriteLine("Dizi Elemanları: ");
            foreach (double eleman in Dizi)
            {
                Console.Write($"{eleman}{ayrac}");
            }
        }
        // dizi.Topla();
        public double Topla()
        {
            double toplam = 0;
            for (int i = 0; i < Boyut; i++)
            {
                toplam += Dizi[i];
            }
            //return Dizi.Sum();
            return toplam;
        }
        public double OrtalamaHesapla()
        {
            double ortalama = 0;
            for (int i = 0; i < Boyut; i++)
            {
                ortalama = (ortalama + Dizi[i]) / Boyut;
                //ortalama = ortalama / Boyut;
            }
            //return Dizi.Average();
            return ortalama;
        }
        // dizi.Ortalama  property
        public double Ortalama => Dizi.Average();
        // dizi.MinimumGetir();
        public double MinimumGetir() => Dizi.Min();
        // dizi.MaximumGetir();
        public double MaximumGetir() => Dizi.Max();

        public double Toplam
        {
            get
            {
                double toplam = 0;
                for (int i = 0; i < Boyut; i++)
                {
                    toplam += Dizi[i];
                }
                //return Dizi.Sum();
                return toplam;
            }
        }
    }
}
