using LearningApp.Lesson12.Animals;
using LearningApp.Lesson12.Gui;
using LearningApp.Lesson12.TaskClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12
{
    class Program12
    {
        static void Main()
        {
            Hero newHero = new Hero();
            Dog newDog = new Dog();
            Ghost newGhost = new Ghost();
            House newHouse = new House();
            Sun newSun = new Sun();

            newHero.Print();
            newDog.Print();
            newGhost.Print();
            newHouse.Print();
            newSun.Print();

        }
    }
}
