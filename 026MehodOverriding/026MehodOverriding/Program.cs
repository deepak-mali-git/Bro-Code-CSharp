using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026MehodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {

            // Method overriding = provides a new version of a method inherited from a parent calss
            //                      inherited method must be: abstract, virtual , or already overriden used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();
            Animal animal = new Animal(); 

            animal.Speak();
            dog.Speak();
            cat.Speak();

            Console.ReadKey();

        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The animal goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The animal goes *meow*");
        }
    }
}
