using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Epson : Printer
    {
        public override void Show()
        {
            Console.WriteLine("\nEpson printer display 8.5 x 13");
            }

        public override void Print()
        {
            Console.WriteLine("\nEpson printer is printing....");
            }

    }
}
