using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson15
{
    class Class1 : IPrintData
    {
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

            public int Age 
        {
            get { return Age; } 
            set { Age = value; } 
        }
        public int testList
        {
            get { return Age; }
            set { Age = value; }
        }

        public Class1 (string Name, int Age)
        {
            this.Name = "Vardenis1";
            this.Age = 30;
        }

        public void Print()
        {
            Console.WriteLine(Name + " " + Age + " " + testList);
        }
    }
}

