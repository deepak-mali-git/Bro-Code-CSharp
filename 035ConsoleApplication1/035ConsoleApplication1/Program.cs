using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             int day = 2;
            if (day == 1)
            {
            Console.WriteLine("Mondyay");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
            Console.WriteLine("Wednesday");
            }
            else if (day == 5)
            {
            Console.WriteLine("Friday");
            }
            else
            {
            Console.WriteLine("Day not found!!!");
            }
            Console.ReadKey();                
        }
    }
}
