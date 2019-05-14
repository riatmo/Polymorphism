using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Printer
    {

        public virtual void Show(){
            Console.WriteLine("\nPrinter display 8.5 x 13");
            }

        public virtual void Print()
        {
            Console.WriteLine("\nPrinter is printing....");
            }

    }
}
