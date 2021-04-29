using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Program14
    {
        static void Main()
        {
            Human boss = new Human("Vytautas");

            Company company = new Company("MyCompany", boss);

            company.HireWorker(new Worker(460, "Jonas", "Valytojas"));

            company.HireWorker(new Worker(500, "Petras", "SuperValytojas"));

            company.AddClient(new Client("Kestas"));

            company.AddClient(new Client("Ona"));

            
            
        }
    }
}
