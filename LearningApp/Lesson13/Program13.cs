using LearningApp.Lesson13.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13
{
    class Program13
    {
        static void Main()
        {
            /*string data = "Hello world, how are you today?";

            //List<int> list = new List<int>();
            //list.Add(1);

            string[] dataSplit = StringUtils.SplitTextToWords(data);

            foreach (var item in dataSplit)
            {
                Console.WriteLine(item);
            }
            
            StaticClass staticClass = new StaticClass();
            NonStatic nonStatic = new NonStatic();
            MixedClass mixedClass = new MixedClass();

            Console.WriteLine(StaticClass.PrintNumber());

            */

            Product productName = new Product("ProductName");
            Product productPrice = new Product(10);
            Product productInStock = new Product(false);

            productInStock.Print();



        }
    }
}
