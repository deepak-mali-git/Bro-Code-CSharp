using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = { 12, 45, 67, 879, 89 };
            foreach (int item in data)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
