using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020StaticModifier
{
    class Program
    {
        static void Main(string[] args)
        {

            // static = modifier to declare to static memebr , which belongs to the class itself
            //           rather than to any specific object


          
            Human h = new Human("a");
            Human h1 = new Human("b");
            Human h2 = new Human("c");
            Human h3 = new Human("d");


            h.eat();
            Human.seat();
            Console.WriteLine(Human.totalPeople);
           
           

            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public static int totalPeople;

        public Human(string name)
        {
            this.name = name;
            totalPeople++;
        }
        public void eat()
        {
            Console.WriteLine(name + " eating");
        }

        public static void seat()
        {
            Console.WriteLine(" s eating ");
        }
 
    }
}

