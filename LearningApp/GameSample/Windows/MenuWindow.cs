using LearningApp.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Windows
{
    class MenuWindow : Window
    {
        private TextBlock titleTextBlock;
        private List<Button> buttonList;

        public MenuWindow() : base(0, 0, 120, 30, "Game menu!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            buttonList = new List<Button>();
            buttonList.Add(new Button(20, 13, 18, 5, "Start"));
            buttonList.Add(new Button(50, 13, 18, 5, "Credits"));
            buttonList.Add(new Button(80, 13, 18, 5, "Quit"));
            buttonList[0].IsActive = true;
        }

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            foreach (Button i in buttonList)
            {
                i.Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public void ChangeActiveButton(int direction)
        {
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].IsActive == true && i + direction >= 0 && i + direction < buttonList.Count)
                {
                    buttonList[i].IsActive = false;
                    buttonList[i + direction].IsActive = true;
                    break;
                }

            }

            Render();
        }

        public string GetActiveButton()
        {
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].IsActive == true)
                {
                    return buttonList[i].Label;
                }

            }

            return string.Empty;
        }
    }
}
