using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    abstract class LiveObject : IPrintMe
    {
        public abstract int GetLifeSpan();

        public void PrintInfo()
        {
            Console.WriteLine("PrintLiveObject");
        }
    }
}
