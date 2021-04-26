using LearningApp.Lesson12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.TaskClass
{
    class Sun : IPrintable, IGlows
    {
        public void Print()
        {
            Console.WriteLine("Printed Sun!");
        }

        public void Glow()
        { 
        
        }

        public int Brightness { get; set; } = 1000;

    }
}
