using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // methods = performs a section of code, whenever it's called "invoked".
            // return = returns data back to the place were a mehtod is called
            // method overloading = mehtods share same name, but different parameters 
            //                      name + parameters = signature, methods must have a unique signature



            called();
            called(1);
            called(1,2);
            called(1,2.2);

            Console.ReadKey();
        }

        static void called()
        {
            Console.WriteLine("caleed empty one");
        }
        static void called(int a)
        {
            Console.WriteLine("caleed single one");
        }
        static void called(int a , int b)
        {
            Console.WriteLine("caleed double one");
        }
        static void called(int a , double b)
        {
            Console.WriteLine("caleed double one int and double");
        }


    }
}
