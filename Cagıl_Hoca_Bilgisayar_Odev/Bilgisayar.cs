using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagıl_Hoca_Bilgisayar_Odev
{
    public class Bilgisayar
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double GHz { get; set; }
        public BilgisayarTipleri BilgisayarTipi { get; set; }
        public short Hafiza { get; set; }
        public byte EkranBoyutu { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public DateTime UretimTarihi { get; set; }

       

    }
    /// <summary>
    /// Bilgisayar tiplerini verir
    /// </summary>
   public enum BilgisayarTipleri
    {
        MasaUstu = 1,
        Laptop,
        Sunucu
    }
}
