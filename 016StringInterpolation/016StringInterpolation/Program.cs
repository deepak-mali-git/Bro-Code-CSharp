using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a stirng  literal precede a string literal with $ 
            //                          {} are placeholders

            string firstName = "first";
            string lastName = "last";
            int age = 20;

            Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            Console.WriteLine("you are " + age + " years old.");

            Console.WriteLine();

            Console.WriteLine("Hellow {0} {1}.",firstName,lastName);
            Console.WriteLine("you are {0} year old.", age);


            Console.ReadKey();
        }

    }
}
