using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025ObjectAsArgument
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Mustang","black");
            

            Car car2 = copy(car);
            changeColor(car, "red");

            Console.WriteLine(car.color + " " + car.model);
            Console.WriteLine(car2.color + " " + car2.model);


            Console.ReadKey();
        }

        public static Car copy(Car car)
        {
            return new Car(car.model, car.color);
        }

        public static void changeColor(Car car , String color)
        {
            car.color = color; 
        }

    }

    class Car
    {
        public String model, color;

        public Car(String m, String c)
        {
            model = m;
            color = c;
        }
    }
}
