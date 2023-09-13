using AbstractClasses.Bases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Product : RecordBase
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int StockAmount { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nName: {Name}\nUnit Price: {UnitPrice.ToString("C2", new CultureInfo("en-US"))}\n" +
                $"Stock Amount:{StockAmount} {(StockAmount > 1 ? "units" : "unit")}";
        }
    }
}
