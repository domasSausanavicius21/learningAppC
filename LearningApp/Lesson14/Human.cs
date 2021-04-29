using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Human : LiveObject
    {
        protected string name;

        public Human (string name)
        {

        }

        public override int GetLifeSpan()
        {
            return 1;
        }
    }
}
