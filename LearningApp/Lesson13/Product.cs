using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13
{
    class Product
    {
        private string name;
        private int price;
        private bool inStock;
        
        public Product (string name)
        {
            this.name = name;            
        }

        public Product(int price)
        {
            this.price = price;            
        }

        public Product(bool inStock)
        {
            this.inStock = inStock;
        }

        public void Move(int price)
        {
            price++;
        }

        public bool Move(bool inStock)
        {
            inStock = false;
            return inStock;
        }

        public void Print(int price)
        {
            Console.WriteLine("New Price: " + price);
        }

        public void Print()
        {
            if (inStock)
            {
                Console.WriteLine("Product is in stock");
            }
            else
            {
                Console.WriteLine("Product is out of stock");
            }
        }
    }
}
