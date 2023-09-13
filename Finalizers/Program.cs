using System.Globalization;

namespace Finalizers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kategori kategori = new Kategori
            {
                Id = 1,
                Adi = "Bilgisayar",
                Aciklamasi = "İşlemçi, ekran kartı, ana kart, Ram"
            };

            Urun urun = new Urun(2, "Monster A1", 50000, 250);
            Console.WriteLine($"ID: {urun.Id}\nAdi: {urun.Adi}\nBirim Fiyatı: {urun.BirimFiyatı.ToString("C2",new CultureInfo("en-Us"))}\nStok Miktarı: {urun.StokMiktarı} adet");
            urun.Dispose();
        }
        class Kategori
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public string Aciklamasi { get; set; }
            public Kategori()
            {
                Console.WriteLine("Kategori constructor'ı çalıştırıldı.");
            }
            ~Kategori()
            {
                //obje temizleme kodları yazılır
                Console.WriteLine("Kategori finalizer'ı çalıştırıldı.");
            }
        }
        class Urun:IDisposable
        {
            public Urun(int id, string adi, float birimFiyatı, short stokMiktarı)
            {
                Id = id;
                Adi = adi;
                BirimFiyatı = birimFiyatı;
                StokMiktarı = stokMiktarı;
            }
            public Urun()
            {
                
            }

            public int Id { get; set; }
            public string Adi { get; set; }
            public float BirimFiyatı { get; set; }
            public short StokMiktarı { get; set; }



            bool _disposed = false;
            public void Dispose() //Bir objeyi oluşturup işimiz bittiğinde garbıç kollektör gelip temizliyor.Temizlik yapıyor hafızada cok yer tutan objelerde kullanılır
            {
                if (!_disposed)
                {
                    _disposed = true;
                    GC.SuppressFinalize(this);
                }
            }
        }
    }
}