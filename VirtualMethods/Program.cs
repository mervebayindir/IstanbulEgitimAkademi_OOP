using System.Globalization;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek1 = new Kopek()
            {
                Adi = "Leo",
                Cinsiyet = Cinsiyet.Erkek,
                DogumTarihi = new DateTime(2014, 5, 8),
                Irki = "Sheltie"
            };
            Kopek kopek2 = new Kopek()
            {
                Adi = "Leo",
                Cinsiyet = Cinsiyet.Erkek,
                DogumTarihi = new DateTime(2014, 5, 8),
                Irki = "Sheltie"
            };
            Console.WriteLine(kopek1==kopek2);  //false

            kopek1.SesCikar();
            Console.WriteLine("***************");
            Kedi kedi = new Kedi()
            {
                Adi = "Garfield",
                Cinsiyet = Cinsiyet.Disi,
                DogumTarihi = DateTime.Parse("05.12.2022", new CultureInfo("tr-TR")),
                Irki = "Scottish"
            };

            kedi.SesCikar();
            Console.WriteLine("****************");
            Console.WriteLine(kedi.ToString());
            Console.WriteLine("****************");
            Console.WriteLine(kedi);  //VirtualMethods.Kedi

        }
    }
    enum Cinsiyet
    {
        Disi,
        Erkek
    }
    class EvcilHayvan
    {
        public string Adi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Irki { get; set; }
        public void YemekYe()
        {
            Console.WriteLine("Evcil hayvan yemek yiyor.");
        }
        public void Uyu()
        {
            Console.WriteLine("Evcil hayvan uyuyor.");
        }
        public virtual void SesCikar()
        {
            Console.WriteLine("Evcil hayvan ses çıkarıyor.");
        }
    }
    class Kopek : EvcilHayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Köpek havlıyor.");
        }
    }
    class Kedi : EvcilHayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Kedi miyavlıyor.");
        }
        public override string ToString()
        {
            return $"Adı: {Adi}\nCinsiyeti: {Cinsiyet}\nDoğum Tarihi: {DogumTarihi.ToString("dd.MM.yyyy")}\nIrkı: {Irki}";
        }
    }
}