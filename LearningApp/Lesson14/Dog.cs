using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Dog : Pet
    {
        private string name;

        public Dog(string name)
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine("PrintInfo");
        }
    }
}
