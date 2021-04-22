using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Eurolyga
{
    class Game
    {
        public string HomeTeam;
        public string AwayTeam;
        public string HomeTeamJersey;
        public string AwayTeamJersey;
        public int HomeTeamPoints;
        public int AwayTeamPoints;

        public Game(string homeTeam, string awayTeam, string homeTeamJersey, string awayTeamJersey, int homeTeamPoints, int awayTeamPoints)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeTeamJersey = homeTeamJersey;
            AwayTeamJersey = awayTeamJersey;
            HomeTeamPoints = homeTeamPoints;
            AwayTeamPoints = awayTeamPoints;
        }

        public void GetGameScore()
        {

        }
        public void CountEachPlayersEff()
        {

        }
    }
}
