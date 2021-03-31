using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.HomeWork1
{
    class Homework1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite mokinio pazymi:");
            int pazymys1 = Convert.ToInt32(Console.ReadLine());
            
            if (pazymys1 == 10)
            {
                Console.WriteLine(pazymys1 + " - puiku!");
            }
            else if (pazymys1 == 9 || pazymys1 == 8)
            {
                Console.WriteLine(pazymys1 + " - labai gerai!");
            }
            else if (pazymys1 == 7 || pazymys1 == 6)
            {
                Console.WriteLine(pazymys1 + " - gerai.");
            }
            else if (pazymys1 == 5)
            {
                Console.WriteLine(pazymys1 + " - vidutiniskai.");
            }
            else if (pazymys1 == 4)
            {
                Console.WriteLine(pazymys1 + " - bent teigiamas.");
            }
            else if (pazymys1 <= 3 && pazymys1 > 0)
            {
                Console.WriteLine(pazymys1 + " - labai blogai.");
            }
            else 
            {
                Console.WriteLine(pazymys1 + " - neteisingai ivestas pazymys.");
            }
        }
    }
}
