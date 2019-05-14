using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer printer;
            Console.WriteLine("Pilih Peinter : ");
            Console.WriteLine("1. Canon");
            Console.WriteLine("2. Epson");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Pilih printer [1-3]");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                 printer = new Canon();
            else if (nomorPrinter == 2)           
                 printer = new Epson();            
            else            
                 printer = new LaserJet();


            printer.Show();
            printer.Print();

            Console.ReadKey();

        }
    }
}
