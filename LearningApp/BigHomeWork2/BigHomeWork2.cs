using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.BigHomeWork2
{
    class BigHomeWork2
    {
        static void Main()
        {

            FindMagicNumber();

        }

        public static int[] IntToArray(int num)
        {
            string holder = num.ToString();

            int[] numbers = new int[holder.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(holder[i].ToString());
            }

            return numbers;
        }

        public static bool DifferentArrayDigits(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        return false;
                    }

                }
            }

            return true;
        }

        public static bool CompareTwoArrays(int[] numbers, int[] numbers2)
        {
            if (numbers.Length != numbers2.Length)
            {
                return false;
            }

            int matchCount = 0; 
                        
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers[i] == numbers2[j])
                    {
                        matchCount++;
                    }

                }
            }

            if (matchCount != numbers.Length)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static void FindMagicNumber()
        {
            for (int i = 100000; i <= 999999; i++)
            {
                int[] currentNumberArray = IntToArray(i);
                int matchCount = 0;

                if (!DifferentArrayDigits(currentNumberArray))
                {
                    continue;
                }


                for (int j = 2; j <= 6; j++)
                {
                    int currentMultipliedNumber = i * j;

                    int[] currentMultipliedNumberArray = IntToArray(currentMultipliedNumber);

                    if (!DifferentArrayDigits(currentMultipliedNumberArray))
                    {
                        break;
                    }

                    if (CompareTwoArrays(currentNumberArray, currentMultipliedNumberArray))
                    {
                        matchCount++;
                    }
                }

                if (matchCount == 5)
                {
                    Console.WriteLine(i);
                }
                
            }
        }

    }
}
