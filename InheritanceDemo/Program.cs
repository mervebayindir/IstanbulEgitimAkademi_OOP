using InheritanceDemo.Bases;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KoseliSekil koseliSekil = new KoseliSekil()
            {
                Genislik = 5,
                Yukseklik = 10,
            };
            Console.WriteLine("Genislik: " + koseliSekil.Genislik + "\nYukseklik: " + koseliSekil.Yukseklik);

            Dikdortgen dikdortgen = new Dikdortgen()
            {
                Genislik = 4,
                Yukseklik = 3,
            };

            Console.WriteLine("Alan: " + dikdortgen.AlanHesapla() + "\nCevre: " + dikdortgen.CevreHesapla());

            int[] sayilar = new int[3]
            {
                1,
                5,
                10
            };

            KoseliSekil[] sekiller = new KoseliSekil[2]
            {
                new Dikdortgen()
                {
                    Genislik =3,
                    Yukseklik=4
                },
                new DikUcgen()
                {
                    Genislik=6,
                    Yukseklik=8
                }
            };

            foreach (KoseliSekil sekil in sekiller)
            {
                if (sekil is Dikdortgen)
                {
                    Console.WriteLine((sekil as Dikdortgen).CevreHesapla());
                }
                else
                {
                    Console.WriteLine(((DikUcgen)sekil).CevreHesapla());
                }

            }

            IHesapla[] shapes = new IHesapla[2]
            {
                new Dikdortgen()
                {
                    Genislik =3,
                    Yukseklik=4
                },
                new DikUcgen()
                {
                    Genislik=6,
                    Yukseklik=8
                }
            };
            Console.WriteLine();
            foreach (IHesapla shape in shapes)
            {
                Console.WriteLine(shape.CevreHesapla());
            }



        }
    }
}