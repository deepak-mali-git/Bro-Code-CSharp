using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _031ListOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();


            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));


            foreach (Player player in players)
                Console.WriteLine(player);


            Console.ReadKey();
        }
    }

    class Player
    {
        public String username;

        public Player(String name)
        {
            this.username = name;
        }

        public override String ToString()
        {
            return "The name is " + username;
        }
    }
}
