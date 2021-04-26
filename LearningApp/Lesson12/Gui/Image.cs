using LearningApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.Gui
{
    class Image : GuiElement, IRenderable
    {
        public void Render()
        {
            Console.WriteLine("Paveiksliukas");
        }
    }
}
