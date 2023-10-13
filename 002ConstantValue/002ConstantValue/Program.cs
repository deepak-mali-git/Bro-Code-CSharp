using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002ConstantValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants = immutable values which are known at compile time and do not change for life of the program

            const double PI = 3.14159;

            // PI = 123.45; you cannot change the value

            Console.WriteLine(PI);
            Console.ReadKey();
            
        }
    }
}
