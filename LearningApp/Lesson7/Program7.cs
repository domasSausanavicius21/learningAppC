using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson7
{
    class Program7
    {
        static void Main()
        {
            /*
            int number = 123;

            int[] numbers = new int[] { 112, 45, 45, 454 };

            List<int> numberList = new List<int>();

            List<int> numberList2 = new List<int>() { 158, 65, 15, 65 };

            List<int[]> arrayInList;

            List<int>[] listInArray;

            Console.WriteLine(numberList2[2]);

            numberList.Add(2); //prideda i lista

            numberList.Insert(2, 1); // 2 siuo atveju indexas, 1 - ka pridet

            List<string> zodziai = new List<string>() { "vienas", "du", "trys" };

            List<string> extra2 = new List<string> { "karves", "pienas" };

            zodziai.AddRange(extra2); //prideda lista extra2 i lista zodziai
            
            
            List<int> newList = new List<int>() { 0 };
            
            Console.WriteLine("Pirminis listas" + newList[0]);

            newList.Add(2);

            Console.WriteLine("Pridejau dvejeta" + newList[1]);

            newList.Insert(1, 1);

            Console.WriteLine("Iterpiu vieneta" + newList[1]);

            List<int> newList2 = new List<int>() { 3, 4, 5, 6 };

            newList.AddRange(newList2);

            newList.ForEach(Console.WriteLine);
            
            newList.InsertRange(7, newList2);
            
            Console.WriteLine(newList[newList.Count - 1]);
            
            newList.ForEach(Console.WriteLine);

            Console.WriteLine();

            newList.RemoveAll(FindEven);

            newList.ForEach(Console.WriteLine);
            

            List<int> newList3 = new List<int>() { 0, 1, 2, 3 };

            Console.WriteLine(newList3[newList3.Count - 1]);

            if (newList3.Contains(0))
            {
                Console.WriteLine("List contains 0!");
                Console.WriteLine("Index of 0 is: " + newList3.IndexOf(0));
            }

            Console.WriteLine(newList3.Find(FindEven));

            newList3.Sum();
            */

            List<int> newList1 = new List<int>();

            Random rnd = new Random();
            

            for (int i = 0; newList1.Count() < 100; i++)
            {
                int nr = rnd.Next(1, 100); 
                newList1.Add(nr);
            }

            newList1.ForEach(Console.WriteLine);

            newList1.RemoveAll(FindOver80);

            Console.WriteLine("List now contains:");
            newList1.ForEach(Console.WriteLine);

            
        }

        static bool FindOver80(int element)
        {
            return element > 80;
        }

        

    }
}
