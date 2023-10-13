using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            Console.WriteLine("This statement is always executed.");
            Console.ReadKey();
        }
    }
}
