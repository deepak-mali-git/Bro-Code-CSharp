using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            char[] ch = { 'A', 'B', 'C', 'D', 'E' };
            char[] ch1 = new char[5];
            int i = 0;
            ch1[0] = 'a';
            ch1[1] = 'b';
            ch1[2] = 'c';
            ch1[3] = 'd';
            ch1[4] = 'e';
            Console.WriteLine("First array: ");
            for (i = 0; i < ch.Length; i++)
            {
            Console.Write(ch[i] + "");
            }
            Console.WriteLine("\nSecond array: ");
            for (i = 0; i < ch.Length; i++)
            {
                Console.Write(ch1[i] + "");
            }
            Console.ReadKey();
         }
    }
}
