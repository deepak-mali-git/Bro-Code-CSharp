using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.Beep();

            /*
             * \a   Bell
             * \b   Backspace
             * \f   Form fed
             * \n   New line
             * \r   Carriage return
             * \v   verticle tab
             * \t   Horizontal tab
             * \?   Literal question mark
             */

            int age = 20;
            double height = 300.5;
            bool alive = true;
            char symbol = '@';
            string name = "code";

            Console.WriteLine("your age is " + age);
            Console.WriteLine("your height is " + height + "cm");
            Console.WriteLine("you are alive " + alive);
            Console.WriteLine("your name is " + name);
            Console.WriteLine("character is  " + symbol);

            Console.ReadKey();
        }
    }
}
