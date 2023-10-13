using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            // Enums  = special "class" that contain a set of named integer constants.
            //          use enum when you have two values that you know will not change,
            //          To get the integer value from an item , you must explicitly convert to an int

            //           name  = integer


            String name = PlanetRadious.Earth.ToString();
            int radius = (int)PlanetRadious.Earth;

            double volume = Volume(PlanetRadious.Earth);

            Console.WriteLine("volume " + volume + "km^3");

            Console.WriteLine("planet: " + name + " radious = " + radius + "km");

            Console.WriteLine(Planets.Pluto + " planet # is " + (int)Planets.Pluto);
            Console.WriteLine(Planets.Pluto.ToString() + " is a planet");

            Console.ReadKey();

        }

        public static double Volume(PlanetRadious radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    enum Planets
    { 
        Mercury = 1,
        Venus,
        Earth,
        Mars,
        Juptier,
        Setern,
        Uranus,
        Neptune,
        Pluto
    }

    enum PlanetRadious
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389 ,
        Juptier = 69911,
        Setern = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }

}
