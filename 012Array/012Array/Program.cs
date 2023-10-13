using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array = a variable that can store multiple values. fixed size

            /*

            String[] cars = { "a" , "b", "c" };

            int[] num = new int[3];

            foreach (String car in cars)
                Console.WriteLine(car);

            Console.WriteLine(cars[0]);

            Console.ReadKey();

            */

            int[,] num = {
                             {1,2,3},
                             {4,5,6},
                             {7,8,9}
                         };

            foreach (int i in num)
                Console.WriteLine(i);

            Console.ReadKey();


        }
    }
}
