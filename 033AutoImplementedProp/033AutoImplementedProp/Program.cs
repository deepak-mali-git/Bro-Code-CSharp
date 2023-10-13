using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033AutoImplementedProp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            //                               you do not have to define a field for aproperty,
            //                               you only have to write get; and / or set ; inside the property


            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);


            Console.ReadKey();


        }
    }

    class Car
    {

        public String Model { get; set; }

        /*
         
          String model;

        public String Model
        {
            get { return model; }
            set 
            {
                model = value;
            }
        }
         
        */


        public Car(String model)
        {
            this.Model = model;
        }
    }
}
