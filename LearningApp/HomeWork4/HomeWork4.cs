using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.HomeWork4
{
    class HomeWork4
    {
        static void Main()

        ///////////////////////
        /// 1 Papildoma
        ///////////////////////
        /*
    {
        Console.WriteLine("Iveskite pirma skaiciu:");
        int skaicius1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Iveskite antra skaiciu:");
        int skaicius2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Iveskite trecia skaiciu:");
        int skaicius3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(max(skaicius1, skaicius2, skaicius3)); ;
    }

    static int max (int skaicius1, int skaicius2, int skaicius3)
    {
        int maxNumber = Math.Max(skaicius1, Math.Max(skaicius2, skaicius3));
        return maxNumber;
    }
        */

        ///////////////////////
        /// 2 Papildoma
        ///////////////////////
        /*
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(inRange(skaicius1, skaicius2, skaicius3));
        }

        static bool inRange (int skaicius1, int skaicius2, int skaicius3)
        {
            return (skaicius1 > skaicius2 && skaicius1 <= skaicius3);
        }
        */

        ////////////////////////
        /// 3 Papildoma
        ////////////////////////
        /*
        {
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(isPrimal(skaicius1));
        }

        static bool isPrimal(int skaicius1)
        {
            //return (skaicius1 <= 1 || (skaicius1 %skaicius1 == 0 && skaicius1 %2 != 0));
            bool result = true;

            if (skaicius1 == 0 || skaicius1 == 1)
            {
                result = false;
                return result;
            }
            else
            {
                for (int a = 2; a <= skaicius1 / 2; a++)
                {
                    if (skaicius1 % a == 0)
                    {
                        result = false;
                        return result;
                    }

                }
            }
        }
    }
    */

        ////////////////////////
        /// 4 Papildoma
        ////////////////////////
        ///
        /*
        {
            const double min = 0.0;
            const double max = 20.0;

            double resultD20 = D20(min, max);

            Console.WriteLine(resultD20);

            static double D20(double min, double max)
            {
                return Random.NextDouble(min, max);
            }
        }
        */
        ////////////////////////
        /// 5 Papildoma
        ////////////////////////
        ///

        {

        }
    }
}