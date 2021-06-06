using BlackJack.Game;
using BlackJack.Gui;
using System;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

            GuiController newController = new GuiController();

            newController.ShowMenu();

            newController.StartGui();
        }
    }
}
