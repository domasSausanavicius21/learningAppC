using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Company : IPrintMe
    {
        private Human boss;
        private readonly string name;
        List<Client> clientList = new List<Client>();
        List<Worker> workerList = new List<Worker>();

        
        public Company(string name, Human boss)
        {
            this.name = name;
            this.boss = boss;
        }

        public string OfficePet
        {
            get
            {
                return OfficePet;
            }
            set
            {
                OfficePet = "doggo";
            }
        }
        public void AddClient (Client client)
        {
            clientList.Add(client);
        }
        public void FireWorker(Worker worker)
        {
            workerList.Remove(worker);
        }

        public void HireWorker (Worker worker)
        {
            workerList.Add(worker);
        }

        public void PrintAllClients()
        {
            Console.WriteLine("Client List:");
            foreach (var client in clientList)
            {
                client.PrintInfo();
            }
        }
        public void PrintAllWorkers()
        {
            Console.WriteLine("Worker List:");
            foreach (var worker in clientList)
            {
                worker.PrintInfo();
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("PrintInfo");
        }
    }
}
