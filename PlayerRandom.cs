using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class PlayerRandom : Player
    {

        public PlayerRandom()
        {
            SetName("Randy");
        }

        public override string generateRps()
        {
            //burn off a number
            RandomStatic.rng.Next(1, 4);
            int x = RandomStatic.rng.Next(1, 4);
            string rps = "";
            if (x == 1)
            {
                rps = "rock";
            }
            else if (x ==2)
            {
                rps = "paper";
            }
            else
            {
                rps = "scissors";
            }
            return rps;
        }
    }
}
