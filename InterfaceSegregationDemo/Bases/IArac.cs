using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationDemo.Bases
{
    public interface IArac
    {
        string Marka { get; set; }
        string Model { get; set; }
        int BeygirGücü { get; set; }
        int TekerlekSayisi { get; set; }
        int MotorHacmi { get; set; }

        YakitTipiEnum YakitTipi { get; set; }

        string AracBilgileriniGetir(string satirSonu = " ");
        
    }
}
