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
            string input1 = Console.ReadLine();
            checkString(input1);
        }

        static bool checkString(string input1)
        {

            char[] skaiciai = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            bool isInteger = false;

            for (int i = 0; i < input1.Length; i++)
            {
                char simbolis = input1[i];
                //Console.WriteLine(simbolis);

                for (int j = 0; j < skaiciai.Length; j++)
                {
                    char simbolis1 = skaiciai[i];

                    if (simbolis == simbolis1)
                    {
                        isInteger = true;
                    }
                    else
                    {
                        isInteger = false;
                    }
                }
            }
            if (isInteger)
            {
                Console.WriteLine("Ivestas tekstas yra skaicius");
            }
            else
            {
                Console.WriteLine("Ivestas tekstas nera skaicius");
            }

            return isInteger;
        }
    }
}
