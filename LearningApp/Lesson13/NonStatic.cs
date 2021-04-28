using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13
{
    class NonStatic
    {
        private int nonStaticNumber = 0;
        public string nonStaticWord = "HiNonStatic";

        public int PrintNonStaticNumber(int number)
        {
            Console.WriteLine(number);
            return number;
        }

        public string PrintNonStaticWord(string word)
        {
            Console.WriteLine(word);
            return word;
        }
    }
}
