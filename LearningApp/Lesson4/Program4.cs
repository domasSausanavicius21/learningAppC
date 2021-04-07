using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson4
{
    class Program4
    {
        static void Main()
        {
            /*
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hi! i is: " + i);
            }
            

            for (int i = 0; i < 20; i += 3)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Iveskite intervalo pradzia:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite intervalo pabaiga:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Bad limits.");
            }
            else 
            {
                for (int i = skaicius1; i <= skaicius2; i++)
                Console.WriteLine("Ciklo skaicius: " + i + " kvadratas: " + (i * i));
            }
            


            int suma = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
                
            }
            Console.WriteLine("Suma =" + suma);
            

            int skaicius = 0;

            while (skaicius < 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
            

            Console.WriteLine("Pasirinkite gerima: \n 1 - Kava; \n 2 - Arbata; \n 3 - Vanduo;");

            int option1 = Convert.ToInt32(Console.ReadLine());

            while (option1 < 1 || option1 > 3)
            {
                Console.WriteLine("Bad input! Do it again");
                option1 = Convert.ToInt32(Console.ReadLine());
            }        
            switch (option1)
            {
                case 1:
                    Console.WriteLine("Pasirinkta: Kava");
                    break;
                case 2:
                    Console.WriteLine("Pasirinkta: Arbata");
                    break;
                case 3:
                    Console.WriteLine("Pasirinkta: Vanduo");
                    break;
                default:
                    Console.WriteLine("Ivestas kitas skaicius");
                    break;
            }
            


            const int totalSeatCount = 8;
            const int windowSeatCount = 4;
            const string answerYes = "yes";
            const string answerNo = "no";
            int allSeatsTaken = 0;
            int windowSeatsTaken = 0;

            string input;

            while (allSeatsTaken < totalSeatCount && windowSeatsTaken < windowSeatCount)
            {
                do
                {
                    Console.WriteLine("Do you want a window seat: \nyes; \nno;");
                    input = Convert.ToString(Console.ReadLine());
                }
                
                while (input != answerYes && input != answerNo);

                if (input == answerYes)
                {
                    windowSeatsTaken++;
                }
                    
                allSeatsTaken++;
                

            }
            
            

            int suma = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 5 == 0)
                    continue;
                if (i > 123)
                    break;

                suma += i;
            }

            Console.WriteLine(suma);

            */

            int suma = 0;
            int i = 0;

            for (; ;)
            {

                if (i % 5 == 0)
                {
                    i++;
                    continue;
                }
                
                if (i > 123)
                {
                    break;
                }
                suma += i;
                i++;
            }

            Console.WriteLine(suma);

        }
    }
}
