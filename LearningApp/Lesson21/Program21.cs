using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson21
{
    class Program21
    {
        static void Main()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2 && s1 != null)
            {
                Console.WriteLine("Ok!");
            }
            else
            {
                Console.WriteLine("Objektai skirtingi");
            }

        }
    }
}
