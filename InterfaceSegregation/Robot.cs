using InterfaceSegregation.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Robot : ICalis
    {
        public void Calis()
        {
            Console.WriteLine("Robot çalışıyor");
        }
    }
}
