using LearningApp.Lesson18.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson18
{
    class Program18
    {
        static void Main()
        {
            
            List<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AverageMark = 6.1, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AverageMark = 9.4, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 21, AverageMark = 5.3, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AverageMark = 8.2, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AverageMark = 4.5, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AverageMark = 9.2, IsGettingTuition = false}
            };

            var canDrink = students.FindAll(s => s.Age > 21);
            var goodStudent = students.FindAll(s => s.AverageMark > 21);

            var canDrinkLinq = from s in students
                         where s.Age > 18
                         select s;

            var getsTuitionLinq = from s in students
                                  where s.AverageMark > 8 && s.IsGettingTuition == true
                                  select s;

            var nameLength = from s in students
                                  where s.AverageMark < 8 && s.Name.Length <= 8
                                  select s;

           //List<string> studentList = (from s in students
           //                            where s.AverageMark > 8 && s.IsGettingTuition == true
           //                            select s).ToList();


            int someNum = 9;

            Console.WriteLine(someNum.PowerTwo());
        }
    }
}
