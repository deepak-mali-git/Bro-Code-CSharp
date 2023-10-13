using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005MathFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math.Pow(,)
            //Math.Sqrt()
            //Math.Abs()
            //Math.Round()
            //Math.Celing()
            //Math.Floor()
            //Math.Max(,)
            //Math.Min(,)




            //########  RANDOM NUMBER GENERATE #########

            /*
            Random random = new Random();
            int num = random.Next(1,7);
            double num2 = random.NextDouble();

            Console.WriteLine(num);
            Console.WriteLine(num2);

            Console.ReadKey();
            */




            //########  HYPOTENUSE #########

            Console.WriteLine("enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();




        }
    }
}
