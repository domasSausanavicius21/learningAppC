using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.Interfaces
{
    interface IGlows
    {
        void Glow();
        int Brightness { get; set; }

    }
}
