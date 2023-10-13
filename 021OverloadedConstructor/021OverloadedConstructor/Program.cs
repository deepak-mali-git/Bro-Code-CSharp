using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021OverloadedConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructor = technique to create multiple constructors,
            //                          with a different set of parameters.

            pizza p = new pizza("wheat bread");
            pizza p1 = new pizza("wheat bread","extra sauce");
        }
    }

    class pizza
    {
        String bread;
        String sauce;

         public pizza(String a)
        {
            bread = a;
        }
        public pizza(String a, String b)
        {
            bread = a;
            sauce = b;
        }
    }
}
