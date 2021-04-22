using LearningApp.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private Frame notActiveFrame;
        private bool isActive = false;
        private TextLine textLine;

        public Button (int x, int y, int width, int height, string name) : base (x, y, width, height)
        {
            activeFrame = new Frame(x, y, width, height, '#');
            notActiveFrame = new Frame(x, y, width, height, '*');
            textLine = new TextLine(x + 2, y + 2, width - 2, name);
        }

        public void Render()
        {

        }
        public void SetActive()
        {

        }
    }
}
