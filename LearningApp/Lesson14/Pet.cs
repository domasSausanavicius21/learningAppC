using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Pet : LiveObject
    {
        public override int GetLifeSpan()
        {
            return 1;
        }

        public void PrintInfo()
        {
            Console.WriteLine("PrintInfo");
        }
    }
}
