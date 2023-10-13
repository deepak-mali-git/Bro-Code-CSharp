using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting = converting a value to a different data type useful when we accept user input (string) different data types can do different things

            double b = 3.14;
            int a = Convert.ToInt32(b);
            double d = Convert.ToDouble(a) + .1;

            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine(d);

            Console.WriteLine(b.GetType());
            Console.WriteLine(a.GetType());
            Console.WriteLine(d.GetType());


            Console.WriteLine("\n\n");

            char e = '@';
            string f = Convert.ToString(e);
            string g = "true";
            bool h = Convert.ToBoolean(g);

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g); 
            Console.WriteLine(h);

            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());

        

            Console.ReadKey();

        }
    }
}
