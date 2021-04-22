using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class Hero : Unit
    {
        private int x;
        private int y;
        private string name;

        public Hero (int x, int y, string name) : base (x, y, name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public void MoveRight()
        {
            x++;
        }

        public void MoveLeft()
        {
            x--;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Hero " + name + " is at X: " + x + " Y: " + y);
        }

    }
}
