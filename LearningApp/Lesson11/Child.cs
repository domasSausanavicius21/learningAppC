using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11
{
    class Child : Parent
    {
        public override void Function1()
        {
            Console.WriteLine("Child 1");
        }

        public new void Function2()
        {
            Console.WriteLine("Child 2");
        }

        public void Function3()
        {
            Console.WriteLine("Child 3");
        }
    }
}
