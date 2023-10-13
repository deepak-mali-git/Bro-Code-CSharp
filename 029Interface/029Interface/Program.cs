using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = define a "contract" that all the classes inheriting from should follow

            //              an interface declares "what a class should have"
            //              an inheriting class define "how it should to do"

            //              Benefit = security + multiple inheritance +  "plug-and-play"


            Rabit rabit = new Rabit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            fish.Flee();
            fish.Hunt();



            Console.ReadKey();
        }
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabit runs away");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fist swim away");
        }

        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for smaller fish");
        }
    }

}
