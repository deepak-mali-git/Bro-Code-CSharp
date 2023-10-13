using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018Object
{
    class Program
    {
        static void Main(string[] args)
        {
            // object  = an instance of a class
            //            a calss can be used as a bluepring to create an object (oop)
            //              objects can have fields & methods (characterstics & action) 

            Human h = new Human();
            h.name = "dk";
            h.age = 20;

            h.eat();
            h.sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public void eat()
        {
            Console.WriteLine(name + " eating");
        }
        public void sleep()
        {
            Console.WriteLine(name + " sleeping");
        }
    }
}
