using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class Unit
    {
        protected int X;
        protected int Y;
        public string name;

        public Unit(int x, int y, string name)
        {
            X = x;
            Y = y;
            name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Unit {name} is at {X} x {Y}");
        }
    }
}
