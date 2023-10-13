using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = 10;
             if (a < 20)
             {
                 if (a == 10)
                 {
                     Console.WriteLine("Inner if block");
                 }
                 Console.WriteLine("Outer if block");
             }
            Console.ReadKey();
        }
    }
}
