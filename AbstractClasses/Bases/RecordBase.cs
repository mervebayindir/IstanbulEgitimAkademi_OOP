using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Bases
{
    public abstract class RecordBase
    {
        public int Id { get; set; }
        public string Guid { get; } // = System.Guid.NewGuid().ToString();

        protected RecordBase()  // constructors protected yapmak daha mantıklı
        {
            Guid = System.Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return $"ID: {Id}\nGuid: {Guid}";
        }
    }
}
