using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson15
{
    struct Person : IPrintData
    {
        public string Name;
        public int Age;
        public List<int> testList;

        public Person (string Name, int Age)
        {
            this.Name = "Vardenis";
            this.Age = 40;
            this.testList = new List<int>();
        }

        public void Print()
        {
            Console.WriteLine(Name + " " + Age + " " + testList);
        }
    }
}
