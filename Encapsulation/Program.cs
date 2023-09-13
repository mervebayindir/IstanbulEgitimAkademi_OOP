namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri()
            {
                Adi = "Merve,",
                Soyadi = "Bayindir",
                Adres = "Antalya, Kepez",
                Yasi = 43,
                CepTelefonu = "5552114477",
                KrediKartNo = "1234 5678 9012 3456",
            };

            Console.WriteLine(musteri);   //Musteri
                                          //
            Console.WriteLine($"Adı: {musteri.Adi} {musteri.Soyadi}\n" +
                $"İletişim: {musteri.CepTelefonu} - {musteri.Adres}\n" +
                $"Yaşı: {musteri.Yasi}\n" +
                $"Kredi Kart No: {musteri.KrediKartNo}\n" +
                $"Cinsiyet: {musteri.Cinsiyet}\n" +
                $"Unvanlı Adı: {musteri.UnvanliAdi}");
           
        }
    }
}