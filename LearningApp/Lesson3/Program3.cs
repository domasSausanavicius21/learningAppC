using System;

namespace LearningApp.Lesson3
{
    class Program3
    {
        static void Main()
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Didziausias skaicius:" + Math.Max(Math.Max(skaicius1, skaicius2), skaicius3));

            if (skaicius1 > skaicius2 && skaicius1 < 100)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra skaiciu ir mazesnis nei 100.");
            }
            if (skaicius2 > 0 && skaicius2 > skaicius1)
            {
                Console.WriteLine("Antras skaicius didesnis nei nulis ir didesnis uz pirma skaiciu.");
            }
            if ((skaicius1 > skaicius2 && skaicius1 > skaicius3) || skaicius1 > 0)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra ir didesnis uz trecia ARBA yra teigiamas");
            }
            if ((skaicius3 >= 5 && skaicius3 <= 10) || skaicius3 > skaicius1 && skaicius3 > skaicius2)
            {
                Console.WriteLine("Trecias skaicius yra tarp 5 ir 10 arba yra didesnis uz pirmaji arba antraji skaiciu");
            }
        }
    }
}
