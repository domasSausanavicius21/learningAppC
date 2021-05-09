using LearningApp.GameSample.Game;
using LearningApp.GameSample.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class GuiController
    {
        private MenuWindow menuWindow;
        private CreditWindow creditWindow;
        private GameController gameController;

        public GuiController()
        {
            menuWindow = new MenuWindow();
            creditWindow = new CreditWindow();
            gameController = new GameController();
        }

        public void ShowMenu()
        {
            menuWindow.Render();
        }

        public void StartGui()
        {
            ConsoleKeyInfo button = Console.ReadKey();
            Console.Clear();

            switch (button.Key)
            {
                case ConsoleKey.RightArrow:
                    menuWindow.ChangeActiveButton(1);
                    break;

                case ConsoleKey.LeftArrow:
                    menuWindow.ChangeActiveButton(-1);
                    break;

                case ConsoleKey.Enter:
                    {
                        string activeButtonLabel = menuWindow.GetActiveButton();
                        switch (activeButtonLabel)
                        {
                            case "Start":
                                gameController.StartGame();
                                break;

                            case "Credits":
                                creditWindow.Render();
                                creditWindow.StartCreditWindow();
                                Console.Clear();
                                ShowMenu();
                                break;

                            case "Quit":
                                return;
                               
                        }
                        break;
                    }

                default:
                    ShowMenu();
                    break;
            }

            StartGui();
        }
    }
}
