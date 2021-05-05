using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson15
{
    class Program15
    {
        static void Main()
        {
            //Person newPerson = new Person("Vardas", 20);
            //Class1 newClass = new Class1("Class1Name", 30);

            int[] masyvas = new int[3];


            try
            {
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            } 
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException rangeException)
            {
                Console.WriteLine("Bad range");
            }

            


        }
    }
}
