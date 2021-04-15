using LearningApp.Eurolyga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson8
{
    class Program8
    {
        static void Main()
        {
            
            Game testGame = new Game("Zalgiris", "Real", "HomeJersey", "AwayJersey", 90, 80);
            
            Table testTable = new Table(1, 10, 0, 1000, 800, "Zalgiris");

            Team testTeam = new Team(1, 10, 0, "HomeJersey", 1000, 800, "Jankunas", 100, 10, "Schiller");

            Console.WriteLine(testGame.HomeTeam + " vs " + testGame.AwayTeam);

            testTable.GetStandings();

            testTeam.CurrentPlace = 3;

            Console.WriteLine(testTeam.CurrentPlace = 2);




        }
    }
}
