using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RpsApp : Player
    {

        public Player playerSelection()
        {
            Console.WriteLine("Press 'r' to play against the Rock Player or 'g' to play against the Random Player");
            string input = Console.ReadLine();
            input = input.Trim();
            input = input.ToLower();
            if (input == "r")
            {
                PlayerRock playerRock = new PlayerRock();
                return playerRock;
            }
            else if (input  == "g")
            {
                PlayerRandom playerRandom = new PlayerRandom();
                return playerRandom;
            }
            else
            {
                Console.WriteLine("Invalid entry. Try again.");
                playerSelection();
                PlayerRock pr = new PlayerRock();
                return pr;
            }
        }

        public override string generateRps()
        {
            return "error";
        }
    }
}
