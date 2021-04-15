using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Eurolyga
{
    class Table
    {
        private int place;
        private int wins;
        private int losses;
        private int pointsScored;
        private int pointsConceded;
        private string team;

        public Table(int place, int wins, int losses, int pointsScored, int pointsConceded, string team)
        {
            this.place = place;
            this.wins = wins;
            this.losses = losses;
            this.pointsScored = pointsScored;
            this.pointsConceded = pointsConceded;
            this.team = team;
        }
        
        public void GetStandings()
        {
            Console.WriteLine("This method returns all standings");
        }
    }
}
