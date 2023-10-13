using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            // Generic = "not specific to a particular data type"
            //            add <T> to: classes, methods, fields etc.
            //            allows for code reusablity for different data types

            int[] intArray = {1,2,3};
            double[] doubleArray = {1.0,2.0,3.0};
            String[] stringArray = {"1","2","3"};

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();

        }

        public static void displayElements<Thing>(Thing[] Array)
        {
            foreach (Thing item in Array)
                Console.Write(item + "  ");

            Console.WriteLine();
        }
    }
}
