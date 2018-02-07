using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class View
    {
        



        public static void menu()
        {
            Console.WriteLine("Welcome to the Rock / Paper / Scissors tournament");
            Console.Write("What is your name: ");
            string userName = Console.ReadLine();
            Human user = new Human();
            user.SetName(userName);
                        
            RpsApp app = new RpsApp();
            Controller.run(user, app.playerSelection());
            
            
        }

        public static string userRps()
        {
            Console.Write("Choose what to shoot: [r]ock, [p]aper, or [s]cissors: ");
            string input = Console.ReadLine();
            input.Trim();
            input.ToLower();
            if (input == "r")
            {
                return "rock";
            }
            else if (input == "p")
            {
                return "paper";
            }
            else if (input == "s")
            {
                return "scissors";
            }
            else
            {
                Console.WriteLine("ERROR: invalid choice. please try again.");
                userRps();
                return "error";
            }

        }

        public static void fight(Player human, Player pc)
        {
            pc.SetRps(pc.generateRps());
            Console.WriteLine("\nYou picked: " + human.GetRps() + " & " + pc.GetName() + " picked: " + pc.GetRps());
            if (human.GetRps() == "rock" && pc.GetRps() =="rock")
            {
                Console.WriteLine("It was a tie!");
                human.SetTies();
                pc.SetTies();
                again();

            }
            else if (human.GetRps() == "rock" && pc.GetRps() == "paper")
            {
                Console.WriteLine("You lost.");
                human.SetLosses();
                pc.SetWins();
                again();

            }
            else if (human.GetRps() == "rock" && pc.GetRps() == "scissors")
            {
                Console.WriteLine("You won.");
                human.SetWins();
                pc.SetLosses();
                again();

            }
            else if (human.GetRps() == "paper" && pc.GetRps() == "paper")
            {
                Console.WriteLine("It was a tie!");
                human.SetTies();
                pc.SetTies();
                again();

            }
            else if (human.GetRps() == "paper" && pc.GetRps() == "scissors")
            {
                Console.WriteLine("You lost.");
                human.SetLosses();
                pc.SetWins();
                again();

            }
            else if (human.GetRps() == "paper" && pc.GetRps() == "rock")
            {
                Console.WriteLine("You won.");
                human.SetWins();
                pc.SetLosses();
                again();

            }
            else if (human.GetRps() == "scissors" && pc.GetRps() == "scissors")
            {
                Console.WriteLine("It was a tie!");
                human.SetTies();
                pc.SetTies();
                again();
            }
            else if (human.GetRps() == "scissors" && pc.GetRps() == "rock")
            {
                Console.WriteLine("You lost.");
                human.SetLosses();
                pc.SetWins();
                again();
            }
            else if (human.GetRps() == "scissors" && pc.GetRps() == "paper")
            {
                Console.WriteLine("You won.");
                human.SetWins();
                pc.SetLosses();
                again();
            }
        }

        

        public static void again()
        {
            

        }

    }
}
