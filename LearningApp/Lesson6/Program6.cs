using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson6
{
    class Program6
    {
        static void Main()
        {
            StringArray();

            Console.WriteLine("Hello Main!");
            string[] masyvas = new string[5];

            for (int i = 0; i < masyvas.Length; i++)

            {
                Console.WriteLine("Iveskite zodi:");
                masyvas[i] = Console.ReadLine();
            }

            Console.WriteLine("Is eiles be tarpu:");
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write(masyvas[i]);
            }

            Console.WriteLine("Atvirksciai:");

            for (int i = masyvas.Length - 1; i >= 0; i--)
            {
                Console.Write(masyvas[i]);
            }

            
        }

        
        
        static void StringArray()
        {
            string[] data = {"Mano", "batai", "Mano", "buvo", "batai", "buvo", "du", "buvo", "du", "." };
            
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length - 1; j++)
                {
                    string firstItem = data[i];
                    string secondItem = data[j];

                    if (firstItem == secondItem)
                    {
                        data[j] = "!";
                    }
                        
                }
                Console.WriteLine(data[i] + " ");
            }

            
        }
    }
}
