using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Client : Human 
    {
        private int clientCount = 0;
        private string name;

        public int ClientID
        {
            get 
            { 
                return ClientID; 
            }
            set
            {
                ClientID += clientCount;
            }
        }
        public Client (string name) : base (name)
        {
            this.name = name;
        }

        

        public void PrintInfo()
        {
            Console.WriteLine("PrintInfo");
        }
    }
}
