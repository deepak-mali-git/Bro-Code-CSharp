using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Loop
{
    class Program
    {
        static void Main(string[] args)
        {


             // while loop = repeats some code while some condition remain true

            String name = "";
            while (name == "")
            {
                Console.WriteLine("enter you name:  ");
                name = Console.ReadLine();
            
            Console.WriteLine("you name is: " + name);

            }
           




            // Foor loop = repeats some code for a Finite amount of time 

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();


        }
    }
}
