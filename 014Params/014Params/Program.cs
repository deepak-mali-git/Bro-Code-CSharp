using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014Params
{
    class Program
    {
        static void Main(string[] args)
        {
            // Params keyword = a method parameter that takes a variable numebr of arguments.
            //                  the parameter type must be a single - dimension Array

            double total = CheckOut(3.99, 5.75, 15);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        private static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
                total += price;

            return total;
        }
    }
}
