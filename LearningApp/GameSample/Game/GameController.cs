using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class GameController
    {
        public void StartGame()
        {
            Hero newHero = new Hero(1, 1, "ChuckNorris");

            newHero.PrintInfo();

            newHero.MoveRight();

            newHero.PrintInfo();


            Random rnd = new Random();

            List<Enemy> enemies = new List<Enemy>();

            int uniqueId = 0;

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(uniqueId, rnd.Next(0, 10), rnd.Next(0, 10)));
                uniqueId++;
            }

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].PrintInfo();
                enemies[i].MoveDown();
                enemies[i].PrintInfo();
            }

            GameScreen myGame = new GameScreen(200, 80);

            myGame.SetHero(new Hero(5, 5, "HERO"));

            myGame.Render();

            myGame.MoveHeroLeft();

            myGame.MoveAllEnemiesDown();

            myGame.Render();
        }

    }
}
