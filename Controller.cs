using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class Controller
    {
        public static void run(Player h, Player pc)
        {
            h.SetRps(View.userRps());

            View.fight(h, pc);

            Console.WriteLine("\n*** FINAL SCORES ***\n");
            Console.WriteLine(h.GetName() + "\tWins: " + h.GetWins() + "\t\tLosses: " + h.GetLosses() + "\tTies: " + h.GetTies());
            Console.WriteLine(pc.GetName() + "\tWins: " + pc.GetWins() + "\t\tLosses: " + pc.GetLosses() + "\tTies: " + pc.GetTies());

            Console.WriteLine("\nPress 'y' to play again or any other key to exit.");
            string input = Console.ReadLine();
            input.Trim();
            input = input.ToLower();
            if (input == "y")
            {
                Console.WriteLine("Press 's' to switch opponents or any other key to keep playing " + pc.GetName());
                string opponent = Console.ReadLine();
                opponent = opponent.Trim();
                opponent = opponent.ToLower();
                if (opponent == "s")
                {
                    
                    View.menu();
                }
                else
                {
                    run(h, pc);
                }
            }
            else
            {
                Console.WriteLine("\n*** Goodbye ***");
            }



        }



    }
}
