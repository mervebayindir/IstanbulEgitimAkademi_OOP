using InterfaceSegregationDemo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationDemo
{
    public class Araba : IArac, IDireksiyon
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int BeygirGücü { get; set; }
        public int TekerlekSayisi { get; set; }
        public int MotorHacmi { get; set; }
        public YakitTipiEnum YakitTipi { get; set; }
        public bool DireksiyonSoldaMı { get; set; }

        public string AracBilgileriniGetir(string satirSonu = " ")
        {
            return $"Marka: {Marka}{satirSonu}" +
                $"Model: {Model}{satirSonu}" +
                $"Tekerlek Sayısı: {TekerlekSayisi}{satirSonu}" +
                $"Beygir Gücü: {BeygirGücü} HP{satirSonu}" +
                $"Motor Hacmi: {MotorHacmi} cc{satirSonu}" +
                $"Yakıt Tipi: {YakitTipi}" +
                $"Direksiyon: {(DireksiyonSoldaMı ? "Solda" : "Sağda")}";
        }
    }
}
