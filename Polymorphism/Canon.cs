using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Canon : Printer
    {
        public override void Show()
        {
            Console.WriteLine("\nCanon printer display 8.5 x 13");
            }

        public override void Print()
        {
            Console.WriteLine("\nCanon printer is printing....");
            }

        
    }
}
