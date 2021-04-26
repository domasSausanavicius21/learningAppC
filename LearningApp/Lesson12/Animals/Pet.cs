using LearningApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.Animals
{
    class Pet : Animal, IMovable, IRenderable
    {
        public int X { get; set; }

        public int Y { get; set; }

        
        public void Move()
        {
            Console.WriteLine("Pet move!");
        }

        public void Render()
        {
            Console.WriteLine("Render pet!");
        }
    }
}
