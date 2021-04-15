using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Eurolyga
{
    class Team
    {
        public int CurrentPlace;
        public int GamesWon;
        public int GamesLost;
        public string JerseyColor;
        public int TotalPointsScored;
        public int TotalPointsConceded;
        private string playerName;
        private int playerEffTotal;
        private int playerEffAvg;
        public string CoachName;

        public Team(int currentPlace, int gamesWon, int gamesLost, string jerseyColor, int totalPointsScored, int totalPointsConceded, string playerName, int playerEffTotal, int playerEffAvg, string coachName)
        {
            CurrentPlace = currentPlace;
            GamesWon = gamesWon;
            GamesLost = gamesLost;
            JerseyColor = jerseyColor;
            TotalPointsScored = totalPointsScored;
            TotalPointsConceded = totalPointsConceded;
            this.playerName = playerName;
            this.playerEffTotal = playerEffTotal;
            this.playerEffAvg = playerEffAvg;
            CoachName = coachName;
        }

        public void NextHomeGame()
        {

        }
        public void NextAwayGame()
        {

        }
        public void GetGameScore()
        {

        }
        public void CountEachPlayersEff()
        {

        }

        private void UseDefence()
        {

        }

        private void UsePlays()
        {

        }
    }

    
}
