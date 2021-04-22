using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class Enemy : Unit
    {
        private int id;
        private int x;
        private int y;
        

        public Enemy(int id, int x, int y) : base (x, y, "name")
        {
            this.id = id;
            this.x = x;
            this.y = y;
        }
        public void MoveDown()
        {
            y--;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Enemy " + id + " is at X: " + x + " Y: " + y);
        }
        public int GetId()
        {
            return id;
        }
    }
}
