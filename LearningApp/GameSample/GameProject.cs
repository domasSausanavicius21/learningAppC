using LearningApp.GameSample.Game;
using LearningApp.GameSample.Gui;
using LearningApp.GameSample.GUI;
using LearningApp.GameSample.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample
{
    class GameProject
    {
        static void Main()
        {
            //GameController gameController = new GameController();
            //gameController.StartGame();

            Console.CursorVisible = false;

            GuiController newController = new GuiController();

            newController.ShowMenu();

            newController.StartGui();
        }
    }
}
