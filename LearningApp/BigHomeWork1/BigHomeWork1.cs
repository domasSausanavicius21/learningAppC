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

            CheckString(input1);

            Between9and9(input1);

            int.TryParse(input1, out int isNumber);

            Console.WriteLine("Skaicius zodziais yra:" + IntToString(isNumber));

        }

        static bool CheckString(string input1)
        {

            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            
            bool isInteger = false;

            for (int i = 0; i < input1.Length; i++)
            {
                char simbolis = input1[i];
                
                for (int j = 0; j < numbers.Length; j++)
                {
                    char simbolis1 = numbers[j];

                    if (simbolis == simbolis1)
                    {
                        isInteger = true;
                        int.TryParse(input1, out int isNumber);
                        break;
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

        static bool Between9and9 (string input1)
        {
            int.TryParse(input1, out int isNumber);
            
            bool Between9and9 = false;

            if (isNumber < 9 && isNumber >= -9)
            {
                Between9and9 = true;
                Console.WriteLine(isNumber + " yra -9 ir 9 intervale.");
            }
            else
            {
                Between9and9 = false;
                Console.WriteLine(isNumber + " nera -9 ir 9 intervale.");
            }

            
            return Between9and9;
        }

        static string IntToString(int isNumber)
        {
            string[] vienetai = { "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni", "desimt", "vienuolika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika" };
            string[] desimtys = { "nulis", "desimt", "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt" };
            string numberInWords = " ";

            //Console.WriteLine(isNumber);

            if (isNumber == 0)
            {
                numberInWords = "Nulis";
                return numberInWords;
            }

            if (isNumber < 0)
            {
                numberInWords += "minus" + IntToString(Math.Abs(isNumber));
            }

            if (isNumber >= 1000000 && isNumber < 2000000)
            {
                numberInWords += IntToString(isNumber / 1000000) + " milijonas ";
                isNumber %= 1000000;
            }
            else if (isNumber >= 2000000 && isNumber < 10000000)
            {
                numberInWords += IntToString(isNumber / 1000000) + " milijonai ";
                isNumber %= 1000000;
            }
            

            if (isNumber >= 1000 && isNumber < 2000)
            {
                numberInWords += IntToString(isNumber / 1000) + " tukstantis ";
                isNumber %= 1000;
            }
            else if (isNumber >= 2000 && isNumber %1000 != 0)
            {
                numberInWords += IntToString(isNumber / 1000) + " tukstanciai ";
                isNumber %= 1000;
            }
            else if (isNumber %1000 == 0)
            {
                numberInWords += IntToString(isNumber / 1000) + " tukstanciu ";
                isNumber %= 1000;
            }

            if (isNumber >= 100 && isNumber < 200)
            {
                numberInWords += IntToString(isNumber / 100) + " simtas ";
                isNumber %= 100;
            }

            else if (isNumber >= 200)
            {
                numberInWords += IntToString(isNumber / 100) + " simtai ";
                isNumber %= 100;
            }
            

            if (isNumber > 0 && isNumber < 20)
            {
                numberInWords += vienetai[isNumber];
            }

            else if (isNumber >= 20)
            {
                if (isNumber % 10 == 0)
                {
                    numberInWords += desimtys[isNumber / 10];
                }
                else 
                {
                    numberInWords += (desimtys[isNumber / 10] + " " + vienetai[isNumber % 10]);
                }
                    
            }

            return numberInWords;
        }


    }
}
