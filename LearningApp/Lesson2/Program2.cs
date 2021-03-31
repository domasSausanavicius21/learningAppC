using System;

namespace LearningApp
{
    class Program2
    {
        static void Main(string[] args)
        {
            /* 
              
            Console.WriteLine("Iveskite apskritimo spinduli");

            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Apskritimo ilgis yra " + 2 * radius * 3.14);
            Console.WriteLine("Apskritimo plotas yra " + 3.14 * (radius * radius));
            

            int data = 10;
            Console.WriteLine(data++);
            Console.WriteLine(++data);
            Console.WriteLine(++data);


            int data1 = +data;
            Console.WriteLine("Data1:" + data1);
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 == skaicius2)
            {
                Console.WriteLine("Skaiciai lygus");
            }
            else
            {
                Console.WriteLine("Skaiciai nelygus");
            }

            if (skaicius1 != skaicius2)
            {
                Console.WriteLine("Skaiciai nelygus");
            } else 

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Skaicius1 didesnis nei skaicius2");
            }

            if (skaicius1 < skaicius2)
            {
                Console.WriteLine("Skaicius2 didesnis nei skaicius1");
            }
            
            if (skaicius1 >= skaicius2)
            {
                Console.WriteLine("Skaicius1 didesnis arba lygus skaiciui2");
            }
            
            if (skaicius1 <= skaicius2)
            {
                Console.WriteLine("Skaicius2 didesnis arba lygus skaiciui1");
            }
            
            /*
            Console.WriteLine("Iveskite amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("Pilnametis");
            } else
            {
                Console.WriteLine("Nepilnametis");
            }

            if (amzius%2 == 0)
            {
                Console.WriteLine("Lyginis");
            }
            else
            {
                Console.WriteLine("Nelyginis");
            }
            
            */



        }
    }
}
