using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] garage = { new Car("Mustang"), new Car("Carvatte"), new Car("Lambo")};


            //Car[] car = new Car[3];
            //car[0] = new Car("Mustang");
            //car[1] = new Car("Corvette");
            //car[2] = new Car("Lambo");


            foreach (Car c in garage)
            {
                Console.WriteLine(c.model);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public String model;

        public Car(String m)
        {
            model = m;
        }
    }
}
