using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int tNumber = 0;
            int rem = 0;
            int rev = 0;
            Console.Write("Enter Number : ");
            tNumber = number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            if (rev == tNumber)
                Console.WriteLine("Given Number is Palindrome");
            else
                Console.WriteLine("Given Number is not a Palindrome");
            Console.ReadKey();
        }
    }
}
