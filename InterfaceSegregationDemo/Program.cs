using InterfaceSegregationDemo.Bases;

namespace InterfaceSegregationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba arac = new Araba()
            {
                BeygirGücü = 184,
                DireksiyonSoldaMı = true,
                Marka = "Mini",
                Model = "Cooper",
                MotorHacmi = 1600,
                TekerlekSayisi = 4,
                YakitTipi = YakitTipiEnum.Benzin
            };

            Console.WriteLine(arac.AracBilgileriniGetir());

            IArac motorsiklet = new Motorsiklet()
            {
                BeygirGücü = 300,
                Marka = "Kawasaki",
                Model = "Z20",
                MotorHacmi = 250,
                TekerlekSayisi = 2,
                YakitTipi = YakitTipiEnum.Elektrik
            };
            Console.WriteLine(motorsiklet.AracBilgileriniGetir());

            IArac araba = new Araba()
            {
                BeygirGücü = 184,
                DireksiyonSoldaMı = true,
                Marka = "Mini",
                Model = "Cooper",
                MotorHacmi = 1600,
                TekerlekSayisi = 4,
                YakitTipi = YakitTipiEnum.Benzin
            };
            Console.WriteLine(motorsiklet.AracBilgileriniGetir());

            (araba as Araba).DireksiyonSoldaMı = false;

            Console.WriteLine(araba.AracBilgileriniGetir());
        }

    }
}