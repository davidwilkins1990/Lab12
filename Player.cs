using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public abstract class Player
    {
        string name = "Default";
        string rps ="";
        int wins =0;
        int losses = 0;
        int ties = 0;
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetRps()
        {
            return rps;
        }

        public void SetRps(string rps)
        {
            this.rps = rps;
        }

        public int GetWins()
        {
            return wins;
        }

        public void SetWins ()
        {
            this.wins = this.wins +1;
        }

        public int GetLosses()
        {
            return losses;
        }

        public void SetLosses()
        {
            this.losses = this.losses + 1;
        }
        public abstract string generateRps();


        public int GetTies()
        {
            return ties;
        }

        public void SetTies()
        {
            this.ties = this.ties + 1;
        }

        public void ResetTies()
        {
            this.ties = 0;
        }

        public void ResetWins()
        {
            this.wins = 0;
        }

        public void ResetLosses()
        {
            this.losses = 0;
        }
    }
}
