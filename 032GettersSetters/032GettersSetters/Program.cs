using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getters & Setters = add security to fields by encapsulation
            //                      They're accessors found within properties


            // properties = combine aspects of both fields and mehtods (share name with field)
            // get accessors = used to return property value
            // set accessors = used to assign a new value
            // value keyword = define the value being assigned by the set (parameter)



            Car car = new Car(400);

            car.Speed = 100099;

            Console.WriteLine(car.Speed);


            Console.ReadKey();
        }
    }

    class Car
    {
        private int speed;

        public Car(int sp)
        {
            speed = sp;
        }

        public int Speed
        {
            get { return speed; } //read
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }

                else
                {
                    speed = value;
                }
                   

            }
        }
    }
}
