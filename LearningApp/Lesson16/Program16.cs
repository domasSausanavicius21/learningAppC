using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson16
{
    class Program16
    {
        static void Main()
        {
            /*
            string testString = "Labas";
            char test = testString[0];
            Console.WriteLine(test);

            int totalChars = testString.Length;
            Console.WriteLine(totalChars);

            string substring1 = testString.Substring(0, 1);
            Console.WriteLine(substring1);

            string remove = testString.Remove(1);
            Console.WriteLine(remove);

            string replace = testString.Replace('a', 's');
            Console.WriteLine(replace);

            string insert = testString.Insert(0, "Labas");
            Console.WriteLine(insert);

            string test1 = "vienas";
            string test2 = "du";

            string concat = string.Concat(test1, test2);
            Console.WriteLine(concat);
            

            StringBuilder myString = new StringBuilder("Pirma eilute\n");
            myString.Append("Antra eilute\n");

            Console.WriteLine(myString.Length);

            myString.AppendLine("Trecia eilute");

            Console.WriteLine(myString);

            string test1 = "vienas";
            string test2 = "du";

            myString.AppendFormat("{0}, {1}", test1, test2 );

            Console.WriteLine(myString);

            myString.Insert(0, "labas", 10);

            Console.WriteLine(myString);
            */

            File.WriteAllText("test.txt", "Labas");

            string testFileText = File.ReadAllText("test.txt");

            Console.WriteLine(testFileText);

            File.AppendAllText("test.txt", " vakaras");

            testFileText = File.ReadAllText("test.txt");

            Console.WriteLine(testFileText);

            
            //File.Delete("test.txt");

            //testFileText = File.ReadAllText("test.txt");

            //Console.WriteLine(testFileText);
            

            bool fileExists = true;

            if (File.Exists("test.txt"))
            {
                fileExists = true;
                Console.WriteLine(fileExists + ", file exists");

            }
            else
            {
                fileExists = false;
                Console.WriteLine(fileExists + ", file doesn't exist");

            }

            File.Create("test1.txt");

            File.Copy("test.txt", "test2.txt");

            string sourceFolder = "D:\\VCS\\LearningAppGit\\LearningApp\bin\\Debug\net5.0";
            string destFolder = "D:\\VCS\\LearningAppGit\\LearningApp\bin\\Debug";


            File.Move("test2.txt", "..\test2.txt");






        }
    }
}
