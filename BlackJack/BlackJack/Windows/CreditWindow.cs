using BlackJack.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Windows
{
    sealed class CreditWindow : Window
    {
        private Button backButton;
        private TextBlock creditTextBlock;

        public CreditWindow() : base(28, 10, 60, 18, "Credits!", '@')
        {
            List<string> creditData = new List<string>();

            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Domas Sausanavicius");
            creditData.Add("");
            creditData.Add("Programuotojas:");
            creditData.Add("Domas Sausanavicius");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Domas Sausanavicius");
            creditData.Add("");

            creditTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, creditData);

            backButton = new Button(28 + 20, 10 + 14, 18, 3, "Back");
            backButton.IsActive = true;
        }

        public override void Render()
        {
            base.Render();
            creditTextBlock.Render();
            backButton.Render();
        }

        public void StartCreditWindow()
        {
            ConsoleKeyInfo button = Console.ReadKey();

            switch (button.Key)
            {
                case ConsoleKey.Escape:
                    return;
                    
                case ConsoleKey.Enter:
                    return;

                default:
                    break;
            }
            StartCreditWindow();
        }
    }
}