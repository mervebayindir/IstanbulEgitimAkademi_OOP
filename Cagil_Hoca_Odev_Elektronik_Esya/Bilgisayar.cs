using Cagil_Hoca_Odev_Elektronik_Esya.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagil_Hoca_Odev_Elektronik_Esya
{
    public class Bilgisayar : ElektronikEsya
    {
        public BilgisayarTipi BilgisayarTipi { get; set; }
        public IslemciTipi IslemciTipi { get; set; }
        public short Hafıza { get; set; }
        public short EkranBoyutu { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public string SuSogutma => SuSogutmaliMi ? "Evet" : "Hayır";

        //public string SuSogutma { get; set; }
        public string Kategori
        {
            get
            {
                if ((IslemciTipi == IslemciTipi.i7 || IslemciTipi == IslemciTipi.i9) && Hafıza >= 16)
                {
                    return "Oyun bilgisayarı";
                }
                return "İş bilgisayarı";
            }
        }
        public override string ToString()
        {
            return $"Marka: {Marka}\nBilgisayar Tipi: {BilgisayarTipi}\nModel: {Model}\nİşlemci Tipi: {IslemciTipi}\n" +
                $"Hafıza: {Hafıza} GB\nEkran Boyutu: {EkranBoyutu}\"\nSu Sogutma var mı: {SuSogutma}\n" +
                $"Seri No: {SeriNo}\nÜretim Tarihi: {UretimTarihi.ToString("dd.MM.yyyy")}\nKategori: {Kategori}";
        }
    }

    public enum IslemciTipi
    {
        i5,
        i7,
        i9,
    }
    public enum BilgisayarTipi
    {
        Dizüstü,
        Masaüstü,
        Sunucu,
    }
}
