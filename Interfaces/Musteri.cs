using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Musteri : IKisi  //somut (concrete), Ogrenci bir IKisi'dir (is a relation)
    {
        public string TcKimlikNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string KrediKartıNo { get; set; } = "0000 0000 0000 0000";

        public string Getir()
        {
            return $"T.C Kimlik No: {TcKimlikNo}\n" +
                $"Tam Adı: {Adi} {Soyadi}" +
                $"Kredi Kart No Son 4 Hane: {KrediKartıNo.Substring(15)}";
        }
    }
}
