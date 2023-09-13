using AbstractClasses.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Store : RecordBase
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
