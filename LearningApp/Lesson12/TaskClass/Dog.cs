﻿using LearningApp.Lesson12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.TaskClass
{
    class Dog : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printed Dog!");
        }
    }
}