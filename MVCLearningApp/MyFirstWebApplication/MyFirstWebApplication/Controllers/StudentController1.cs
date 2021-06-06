using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Models.University;

namespace MyFirstWebApplication.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {

            List<Student> students = new List<Student>()
            {
                new Student(){Id = 0, Name = "petras", City = "Vilnius", Score = 1.5, IsGettingTuition = true },
                new Student(){Id = 1, Name = "ona", City = "Vilnius", Score = 5.5, IsGettingTuition = false },
                new Student(){Id = 2, Name = "gabriele", City = "Kaunas", Score = 2.5, IsGettingTuition = true },
                new Student(){Id = 3, Name = "tadas", City = "Vilnius", Score = 3.5, IsGettingTuition = false },
                new Student(){Id = 4, Name = "vytas", City = "Vilnius", Score = 4.5, IsGettingTuition = true }
            };


            return View(students);
        }
    }
}