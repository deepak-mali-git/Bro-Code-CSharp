using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {


            
            bool playAgain = true;
            int guess = 0, number, guesses = 0;
            string st;


            while (playAgain)
            {

                Random rand = new Random();
                number = rand.Next(1, 101);

                while (guess != number)
                {
                    Console.WriteLine("guess the number:  ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("guess: " + guess);

                    if (guess < number)
                        Console.WriteLine("guess low");
                    else if (guess > number)
                        Console.WriteLine("guess high");
                    guesses++;
                }

                Console.WriteLine("you win");
                Console.WriteLine("guesses = " + guesses);

                Console.WriteLine("\ndo you want to play again y/n");

                st = Console.ReadLine().ToUpper();


                if (st == "Y")
                    playAgain = true;
                else
                    playAgain = false;

            }
            Console.WriteLine("thanks for playing");
            Console.ReadKey();
          


        }
    }
}
