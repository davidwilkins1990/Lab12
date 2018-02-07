using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class PlayerRock : Player
    {

        public PlayerRock()
        {
            this.SetName("Brock");
        }

        public override string generateRps()
        {
            //player always shoots rock
            return "rock";
        }

        
    }
}
