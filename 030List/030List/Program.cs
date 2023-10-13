using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _030List
{
    class Program
    {
        static void Main(string[] args)
        {

            // List = data structure that represent a list of objects that can be accessed by index.
            //         similar to array, but can dynamicaly increase/decrease in 
            //          using System.Collections.Generic


            List<String> food = new List<String>();

            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("fries"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            String[] FoodArray = food.ToArray();
            

            foreach (String st in food)
                Console.WriteLine(st);

            Console.WriteLine();

            foreach (String st in FoodArray)
                Console.WriteLine(st);


            Console.ReadKey();


        }
    }
}
