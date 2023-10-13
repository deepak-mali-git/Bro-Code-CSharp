using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            // Abstract classes = modifier that indicates missing  components or incomplite implementation


            car car = new car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            //Vehicle vehicle = new Vehicle();

          

            Console.ReadKey();
        }
    }

    abstract class Vehicle
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
        int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }


}
