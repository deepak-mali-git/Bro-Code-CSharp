using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool playAgain = true;
            String  player, computer;
            int tie, loss, win, count = 1;



            tie = loss = win = 0;
            player = "";
            computer = "";


            while (playAgain)
            {

            

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("ROCK PAPER OR SCISSORS");
                    player = Console.ReadLine().ToUpper();
                }


                int randNum = rand.Next(1, 4);
                switch (randNum)
                {
                    case 1: computer = "ROCK";
                        break;
                    case 2: computer = "PAPER";
                        break;
                    default: computer = "SCISSORS";
                        break;
                }

                if(player == "ROCK")
                {
                    if(computer == "ROCK")
                    {
                        Console.WriteLine("MATCH TS TIE");
                        tie++;
                    }

                    else if(computer == "PAPER")
                    {
                        Console.WriteLine("You loss");
                        loss++;
                    }

                    else
                    {
                        Console.WriteLine("You win");
                        win++;
                    }
                }

                else if(player == "PAPER")
                {
                     if(computer == "ROCK")
                    {
                        Console.WriteLine("You win");
                        win++;
                    }

                    else if(computer == "PAPER")
                    {
                        Console.WriteLine("Match tie");
                        tie++;
                    }

                    else
                    {
                        Console.WriteLine("You loss");
                        loss++;
                    }
                }

                else
                {
                     if(computer == "ROCK")
                    {
                        Console.WriteLine("You loss");
                        loss++;
                    }

                    else if(computer == "PAPER")
                    {
                        Console.WriteLine("You win");
                        win++;
                    }

                    else
                    {
                        Console.WriteLine("Match tie");
                        tie++;
                    }

                     
                }

                player = "";
                computer = "";

                Console.WriteLine("Win : {0}\nLoss : {1}\nTies : {2}", win, loss, tie);
                count++;

                if (count > 5)
                {

                    Console.WriteLine("do you want to play again y/n");
                    string st = Console.ReadLine().ToUpper();
                    char ch = st[0];
                    if (ch == 'Y')
                        count = 1;
                    else
                        playAgain = false;

                }
            }


        }
    }
}
