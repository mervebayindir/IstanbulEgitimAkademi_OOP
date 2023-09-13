using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Ogrenci : IKisi  //somut (concrete), Ogrenci bir IKisi'dir (is a relation)
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Bolumu { get; set; }

        public string Getir()
        {
            return $"T.C Kimlik No: {TcKimlikNo}\n" +
               $"Tam Adı: {Adi} {Soyadi}" +
               $"Bolumu: {Bolumu}";
        }
    }
}
