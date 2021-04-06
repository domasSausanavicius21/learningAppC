using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.HomeWork3
{
    class HomeWork3
    {
        static void Main(string[] args)
        {

            ///////// PAPILDOMA UZDUOTIS 1 /////////
            /*
            Console.WriteLine("Pasirinkite gerima: \n 1 - Limonadas; \n 2 - Arbata; \n 3 - Kakava; \n 4 - Kava; \n 5 - Nieko; \n ");
            int option1 = Convert.ToInt32(Console.ReadLine());

            if (option1 == 1)
            {
                Console.WriteLine(option1 + " - Jus pasirinkote limonada");
            }
            else if (option1 == 2)
            {
                Console.WriteLine(option1 + " - Jus pasirinkote arbata");
            }
            else if (option1 == 3)
            {
                Console.WriteLine(option1 + " - Jus pasirinkote kakava");
            }
            else if (option1 == 4)
            {
                Console.WriteLine(option1 + " - Jus pasirinkote kava");
            }
            else if (option1 == 5)
            {
                Console.WriteLine(option1 + " - Jus nepasirinkote nieko");
            }
            else
            {
                Console.WriteLine(option1 + " - blogai ivestas pasirinkimas");
            }
            */

            ///////// PAPILDOMA UZDUOTIS 2 /////////
            /*
            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rezultatas: " + (skaicius1 * skaicius2 * skaicius3));
            */

            ///////// PAPILDOMA UZDUOTIS 3 /////////
            /*
            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sudetis: " + (skaicius1 + skaicius2));
            Console.WriteLine("Atimtis: " + (skaicius1 - skaicius2));
            Console.WriteLine("Daugyba: " + (skaicius1 * skaicius2));
            Console.WriteLine("Dalyba: " + (skaicius1 / skaicius2));
            */

            ///////// PAPILDOMA UZDUOTIS 4 /////////
            /*
            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite ketvirta skaiciu:");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            double result = (skaicius1 + skaicius2 + skaicius3 + skaicius4) / 4;
            Console.WriteLine("Skaiciu " + skaicius1 + "," + skaicius2 + "," + skaicius3 + "," + skaicius4 + " vidurkis yra: " + result);
            */

            ///////// PAPILDOMA UZDUOTIS 5 /////////
            /*
            Console.WriteLine("Iveskite temperatura Farenheitais:");
            int farenheitai1 = Convert.ToInt32(Console.ReadLine());
            
            double celsius1 = (farenheitai1 - 32) * 0.5556;
            Console.WriteLine(farenheitai1 + " farenheitu yra lygu " + celsius1 + " laipsniams Celsijaus");
            */

            ///////// PAPILDOMA UZDUOTIS 6 /////////

            Console.WriteLine("Kiek darbuotojas iskepa kepalu per valanda?");
            int kepalaiPerValanda = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek darbuotoju turi kepykla?");
            int turiKepykla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo savikaina:");
            int savikaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo pardavimo kaina:");
            int pardavimoKaina = Convert.ToInt32(Console.ReadLine());

            int darboValandos = 8;

            int kepalaiPerDiena = (kepalaiPerValanda * darboValandos) * turiKepykla;
            Console.WriteLine("Per diena bus iskepta " + kepalaiPerDiena + " duonos kepalu.");

            int visuKepaluSavikaina = (kepalaiPerDiena * savikaina);
            Console.WriteLine("Per diena iskeptu kepalu savikaina yra " + visuKepaluSavikaina + " eurai.");

            int pajamos = pardavimoKaina * kepalaiPerDiena;
            Console.WriteLine("Per diena gautos pajamos yra " + pajamos + " eurai.");

            int pelnas = pajamos - visuKepaluSavikaina;
            Console.WriteLine("Dienos pelnas yra " + pelnas + " eurai.");



        }
    }
}
