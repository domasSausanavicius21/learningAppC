using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13
{
    class StaticClass
    {
        public static int number = 0;
        private static string word = "Hi";

        public static int PrintNumber()
        {
            Console.WriteLine(number);
            return number;
        }

        private static string PrintWord()
        {
            Console.WriteLine(word);
            return word;
        }
    }
}
