using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.BigHomeWork1
{
    class BigHomeWork1
    {
        static void Main()
        {
            Console.WriteLine("Iveskite skaiciu [-9...9]:");
            string number1 = Console.ReadLine();
            stringIsInt();
        }

        static void stringIsInt()
        {
            string zodis = "Labas";
            for (int i = 0; i < zodis.Length; i++)
            {
                char simbolis = zodis[i];
                Console.WriteLine(simbolis);
            }
        }
    }
}
