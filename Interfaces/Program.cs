namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = "Merve",
                Soyadi = "Bayındır",
                Bolumu = "Bilgisayar Programcılığı",
                TcKimlikNo = "12345678901",
            };
            Console.WriteLine(ogrenci.Getir());

            Musteri musteri = new Musteri();
            musteri.Adi = "Zümra";
            musteri.Soyadi = "Bayındır";
            musteri.KrediKartıNo = "1234 5678 9012 3456";
            musteri.TcKimlikNo = "12345678123";

            Console.WriteLine(musteri.Getir());

            IKisi kisi1 = new Musteri();  // polymorphism
            kisi1.Adi = "Kutluhan";
            kisi1.Soyadi = "Bayındır";
            kisi1.TcKimlikNo = "12345678901";
            //kisi1.Bolumu bu şeklinde olursa sadece IKisi'deki özellikleri yazabiliriz Musteri'deki özellikler gelmez
            string kisiBilgileri = kisi1.Getir();
            Console.WriteLine(kisiBilgileri);

            kisi1 = new Musteri()
            {
                Adi = "Kutluhan",
                Soyadi = "Bayındır",
                TcKimlikNo = "12345678905",
                KrediKartıNo = "1234 5678 9012 3456", // Bu şekilde olur sadece
            };
            IKisi kisi2 = new Ogrenci();


            Musteri musteri2 = (Musteri)kisi1; // kisi1'i Musteri tipine cast ettik
            Console.WriteLine(musteri2.Adi + " " + musteri2.Soyadi + "\n" + musteri2.TcKimlikNo + "\n" + musteri2.KrediKartıNo);


            kisi1 = new Ogrenci()
            {
                Adi = "Kutluhan",
                Soyadi = "Bayındır",
                TcKimlikNo = "12345678905",
                Bolumu = "Bişişim",
            };

            Ogrenci ogr = kisi1 as Ogrenci; //Cast ettmek bu şeildede olabılır
            Console.WriteLine(ogr.Adi + " " + ogr.Soyadi + "\n" + ogr.TcKimlikNo + "\n" + ogr.Bolumu);

        }
    }
}