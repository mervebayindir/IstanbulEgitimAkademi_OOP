using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public byte Yasi { get; set; }
        public string CepTelefonu { get; set; }
        public string Adres { get; set; }

        string _krediKartNo;  // field  (alan)  // public olmaz
        public string KrediKartNo
        {
            get
            {
                // 6666 8974 1526 1324
                // **** **** **** 1234
                return "**** **** **** " + _krediKartNo.Substring(15);
            }
            set
            {
                _krediKartNo = value;  //özellik (property)
            }
        }
        public string KrediKartNo2
        {
            get => "**** **** ****" + _krediKartNo.Substring(15);
            set => _krediKartNo = value;
        }
        public bool ErkekMi { get; set; }
        public string Cinsiyet // readonly  ==> atama yapılmaz okuma yapılır ( sadece get işlemi varsa=readonly dir )
        {
            get
            {
                return ErkekMi ? "Erkek" : "Kadin";
            }
        }
        public string Cinsiyet2 => ErkekMi ? "Erkek" : "Kadın";  // Readonly sadece get methodu

        public string UnvanliAdi => ErkekMi ? "Bay " : "Bayan " + Adi + " " + Soyadi;
    }
}
