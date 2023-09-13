using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IKisi  // Abstract (soyut)
    {
        string TcKimlikNo { get; set; } //  public string TcKimlikNo { get; set; } özellik tanıma public kullanılması uygun değil

        string Adi { get; set; } // özellik tanımı

        string Soyadi { get; set; }

        //string _ortaAdi; alanlar tanımlanamaz

        string Getir(); // method tanımı
    }
}
