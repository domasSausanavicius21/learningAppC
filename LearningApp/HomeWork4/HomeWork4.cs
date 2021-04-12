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

        ///// 4.1  D20
        /*
        {
            const int min = 0;
            const int max = 20;

            int resultD20 = D20(min, max);

            Console.WriteLine(resultD20);

            static int D20(int min, int max)
            {
                int resultD20 = new Random().Next(min, max);
                return resultD20;
            }
        }
        */

        ///// 4.2 D10
        /*
        {
            const int min = 0;
            const int max = 10;

            int resultD10 = D10(min, max);

            Console.WriteLine(resultD10);

            static int D10(int min, int max)
            {
                int resultD10 = new Random().Next(min, max);
                return resultD10;
            }
        }
        */

        ///// 4.3 D6
        /*
        {
            const int min = 0;
            const int max = 6;

            int resultD6 = D6(min, max);

            Console.WriteLine(resultD6);

            static int D6(int min, int max)
            {
                int resultD6 = new Random().Next(min, max);
                return resultD6;
            }
        }
        */



        ////////////////////////
        /// 5 Papildoma
        ////////////////////////
        ///
        /*
        {
            int from = 0;
            int to = 100;
            Console.WriteLine("Iveskite skaiciu nuo " + from + " iki " + to);
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            inRange(skaicius1, from, to);

            static int inRange (int skaicius1, int from, int to)
            {

                while (skaicius1 <= from || skaicius1 >= to);
                {
                    Console.WriteLine("Blogai ivestas skaicius, iveskite skaiciu is naujo.");
                    skaicius1 = Convert.ToInt32(Console.ReadLine());
                }

                if (skaicius1 >= from && skaicius1 <= to);
                {
                    return skaicius1;
                }

            }

                //Console.WriteLine(skaicius1);

        } 
        
            */
        {

        }
    }
    
        
}

