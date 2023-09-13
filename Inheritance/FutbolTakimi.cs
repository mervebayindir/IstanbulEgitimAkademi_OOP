using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class FutbolTakimi:Takim  // FutbolTakimi bir Takim'dir. Sub,  child
    {
        public string TeknikDirektorAdi { get; set; }
        public string KaleciAdi { get; set; }
        public string DefansOyuncuAdlari { get; set; }
        public string OrtaSahaOyuncuAdlari { get; set; }
        public string ForvetOyuncuAdlari { get; set; }
        public string OyunSistemi { get; set; }

        public string KadroGetir()
        {
            return $"Teknik Direktör: {TeknikDirektorAdi}\nKaleci: {KaleciAdi}\n" +
                $"Defans Oyuncuları: {DefansOyuncuAdlari}\nOrta Saha Oyuncuları: {OrtaSahaOyuncuAdlari}\n" +
                $"Forvet oyuncuları: {ForvetOyuncuAdlari}";
        }
    }
}
