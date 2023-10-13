using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more classes receving fields, methods etc. from a common parent

            car car = new car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            Vehicle vehicle = new Vehicle();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.WriteLine(vehicle.speed);
            vehicle.go();

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }

    class car : Vehicle
    { 
        public int wheels = 4;  
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }


}
