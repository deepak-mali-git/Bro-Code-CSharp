using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            // constructor = A special mehtod in a class same name as the class name 
            //               cam ne used to assign values to fields when creating an object 

            Human h = new Human("dk",26);

            

            h.eat();
            h.sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

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
