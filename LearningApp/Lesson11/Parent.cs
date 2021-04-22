using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11
{
    class Parent
    {
        public virtual void Function1()
        {
            Console.WriteLine("Parent 1");
        }

        public void Function2()
        {
            Console.WriteLine("Parent 2");
        }

        public void Function3()
        {
            Console.WriteLine("Parent 3");
        }
    }
}
