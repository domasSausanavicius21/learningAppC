using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Worker : Human
    {
        private int salary;
        private string name;
        private string title;

        public Worker(int salary, string name, string title) : base (name)
        {
            this.salary = salary;
            this.name = name;
            this.title = title;
        }

        public void SetSalary(int salary)
        {
            salary = salary;
        }

        public int GetSalary()
        {
            return salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Emplyoyee " + name + salary);
        }


    }
}
