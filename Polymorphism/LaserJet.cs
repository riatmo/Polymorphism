using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class LaserJet : Printer
    {
        public override void Show()
        {
            Console.WriteLine("\nLaserJet printer display 8.5 x 13");
            }

        public override void Print()
        {
            Console.WriteLine("\nLaserJet printer is printing....");
            }
    }
}
