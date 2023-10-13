using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() = converts an object to its string representation so that it is sutable for display


            Car car = new Car("Chevy","Corvette","Blue",2022);

            Console.WriteLine(car);
            Console.WriteLine(car.ToString());


            Console.ReadKey();
        }
    }

    class Car
    {
        String make, model, color;
        int year;

        public Car(String make, String model, String color, int year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public override string ToString()
        {
            return "this is a " + make  + " " + model;
        }
    }
}
