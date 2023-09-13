namespace OOP_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan;  //declaration
            insan = new Insan();  //initialization, obje (instance) oluşturma

            insan._adi = "Merve";
            Console.WriteLine("Adı: " + insan._adi);

            insan.SetAdi("Merve");
            string ad = insan.GetAdi();
            Console.WriteLine("Adı: " + ad);   // Adı:Merve

            insan.SetSoyadi("Bayındır");
            Console.WriteLine("Soyadı: " + insan.GetSoyadi());   // Soyadı: Alsaç

            insan.SetYasi(32);
            Console.WriteLine("Yaşı: " + insan.GetYasi());    // Yaşı: 43

            insan.GetAdiSoyadi(); // Merve bayıdır

            //Insan yeniInsan = new Insan();
            //yeniInsan.SetAdi("Kutluhan");
            //yeniInsan.SetAdi("Zümra");  // En son girilen ismi atar methoda
            //yeniInsan.SetSoyadi("Bayındır");
            //yeniInsan.GetAdiSoyadi();

            //insan = new Insan();
            //Console.WriteLine(insan.GetAdi());  // viçinde veri olmadıgı için boş

            Insan yeniInsan = insan;  //yeniInsan => insan objesinin referans değerini tutar ve içindekileri verir bize
            yeniInsan.GetAdiSoyadi();

            OOP_Class.Insan yepYeniInsan= new OOP_Class.Insan();  // Aynı namerSpace üzerinden de ulaşılabilir classa ama aynı namespace üzerinden ulaşırken yazmamıza gerek yok başka namespace olursa yazması zorunludur.
            // _adi // değeri yok,  null
            // _soyadi  // değeri yok  null
            // _yasi  = 0 değer tip oldugu ıcın ılk değer olarak 0 atanır
            Console.WriteLine(yepYeniInsan.GetAdi());
            Console.WriteLine(yepYeniInsan.GetYasi());
            char c = yepYeniInsan.GetCinsiyet();
            Console.WriteLine(c);


        }
    }
    class Insan
    {
        //field (alan)
        public string _adi;
        string _soyadi;
        int _yasi;
        char _cinsiyet;

        public void SetCinsiyet(char cinsiyet)
        {
            _cinsiyet=cinsiyet;
        }
        public char GetCinsiyet()
        {
            return _cinsiyet;
        }

        //public void SetAdi(string adi)
        //{
        //    this.adi = adi;  // this yerine  ( _ )yapılır
        //}

        //public void SetAdi(string name)
        //{
        //    adi = name;  // this yerine  ( _ )yapılır
        //}

        public void SetAdi(string adi)
        {
            _adi = adi;  // this yerine  ( _ )yapılır
        }

        public string GetAdi()
        {
            return _adi;
        }

        public void SetSoyadi(string soyadi)
        {
            _soyadi = soyadi;
        }
        public string GetSoyadi()
        {
            return _soyadi;
        }
        public void SetYasi(int yasi)
        {
            _yasi = yasi;
        }
        public int GetYasi()
        {
            return _yasi;
        }

        public void GetAdiSoyadi()
        {
            Console.WriteLine($"{_adi} {_soyadi}");
        }

    }
}