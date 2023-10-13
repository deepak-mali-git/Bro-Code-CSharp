using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism = Greek word that means to "have many forms"
            //                  Object can be identified by more than one type


            
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bicycle,boat};


            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.go();
            }

            Console.ReadKey();

        }
    }

    class Vehicle
    {
        public virtual void go() 
        {
            
        }
    }

    class Car : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The car is moving");
        }
    }

    class Bicycle : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The boat is moving");
        }
    }
}
