using AbstractVsInterface.Bases;

namespace AbstractVsInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOgrenciDosya ogrenciDosya = new MetinselOgrenciDosya()
            {
                //DosyaYolu = "C:\\Okul\\Öğrenciler.txt";
                //DosyaYolu = @"C:\Okul\Öğrenciler.txt";
                //DosyaYolu = "C:\\Users\\Merve\\source\\repos\\OOP\\AbstractVsInterface\\Dosyalar\\Öğrenciler.txt";
                DosyaYolu = "../../../Dosyalar/Öğrenciler.txt"
            };
            Console.Write("Öğrenciler\n" + ogrenciDosya.OgerncileriGetir());
            Console.Write("\nYeni öğrenci Girişi\n");
            Console.Write("Adı: ");
            string adi = Console.ReadLine().Trim();
            Console.Write("Soyadı: ");
            string soyadi = Console.ReadLine().Trim();
            Console.Write("Yaşı: ");
            int yas;
            if(!int.TryParse(Console.ReadLine().Trim(), out yas))
            {
                Console.WriteLine("Yaş sayısal olmalıdır!");
            }
            else
            {
                string yeniOgrenci = $"Adı:{adi} - Soyadı:{soyadi} - Yaşı:{yas}";
                ogrenciDosya.OgrenciEkle(yeniOgrenci);
            }
            Console.Write("\nÖğrenciler\n" + ogrenciDosya.OgerncileriGetir());



        }
    }
}