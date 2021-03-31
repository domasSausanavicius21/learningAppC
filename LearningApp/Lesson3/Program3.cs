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

            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine(skaicius1 + skaicius2 + skaicius3);
                    break;
                case 2:
                    Console.WriteLine(skaicius1 - skaicius3);
                    break;
                case 3:
                    Console.WriteLine(skaicius2 * skaicius3);
                    break;
                default:
                    Console.WriteLine("Ivestas kitas skaicius");
                    break;
            }
        }
    }
}
