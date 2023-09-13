using System.Globalization;

namespace ClassProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.Marka = "Mercedes";
            araba.Model = "Cooper S";
            araba.Renk = Renkler.Mavi;
            araba.TrafigeCikisTarihi = new DateTime(2023, 08, 16);  // Değer tiplar verisi olmayınca default değerleri ekler ===  Referance tipler null verır Struct ve class ikiside newlenerek kullanılır
            araba.MotorHacmi = 1.6;
            araba.KapiSayisi = 2;
            araba.BeygirGucu = 184;
            Console.WriteLine("Marka: " + araba.Marka); //Marka: Mini
            Console.WriteLine("Model: " + araba.Model);  //Model: Cooper S
            Renkler renk = araba.Renk;
            Console.WriteLine("Renk: " + araba.Renk + " (" + (int)araba.Renk + ") "); //Renk Yaşil
            Console.WriteLine("Renk: " + araba.Renk + " (" + (int)renk + ") "); //Renk Yaşil
            Console.WriteLine("Motor Hacmi: " + araba.MotorHacmi.ToString("N1", new CultureInfo("tr-TR")));  //N1 => Ondalıklı sayının bir hanesini formatlayıp verir.N=> Number 1=Bir hanesini al  C=> Para birimi işaretini koyar
            Console.WriteLine("Kapı sayısı: " + araba.KapiSayisi + " kapı"); 
            Console.WriteLine("Trafiğe çıkış tarihi: " + araba.TrafigeCikisTarihi.ToShortDateString()); 
            Console.WriteLine("Beygir gücü: " + araba.BeygirGucu + "HP"); 








        }
    }

    /// <summary>
    /// Bu bir araba sınıfıdır
    /// </summary>
    class Araba
    {
        //string _marka; // field (alan)
        //public void SetMarka(string marka)
        //{ 
        //    _marka = marka; 
        //}
        //public string GetMarka()
        //{
        //    return _marka;
        //}

        public string Marka { get; set; }   // özellik (property)
        public string Model { get; set; }
        public Renkler Renk { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGucu { get; set; }

        /// <summary>
        /// Motor hacmi CC Cinsindendir
        /// </summary>
        public double MotorHacmi { get; set; }
        public DateTime TrafigeCikisTarihi { get; set; }

    }

}