using LearningApp.Lesson18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson19
{
    class Program19
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AverageMark = 6.1, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AverageMark = 9.4, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 19, AverageMark = 5.3, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AverageMark = 8.2, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 15, AverageMark = 4.5, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AverageMark = 9.2, IsGettingTuition = false}
            };

            var orderByAverageMark = from s in students
                                     orderby s.AverageMark
                                     select s;

            var orderByAge = from s in students
                                     orderby s.Age descending
                                     select s;

            var orderbyAgeAndMark = from s in students
                                    orderby s.Age, s.AverageMark descending
                                    select s;

            var byMark = students.OrderBy(s => s.Age);
            var byAge = students.OrderBy(s => s.AverageMark);
            var byAgeAndMark = students.OrderBy(s => s.Age).ThenByDescending(x => x.AverageMark);

            

            var byAge1 = students.GroupBy(s => s.Age);

            var ageGroups = from s in students
                             group s by s.Age;

            var filterNames = from s in students
                              where s.Age > 20 && s.Age < 35
                              select s.Name;

            foreach (var item in filterNames)
            {
                Console.WriteLine("" + item.ToString());
            }

            var over20 = from s in students
                         where s.Age > 20
                         select new { s.Id, s.Name };

            foreach (var student in over20)
            {
                Console.WriteLine("Id={0}, Name={1}", student.Id, student.Name);
            }


            var getsTuition = from s in students
                              where s.IsGettingTuition
                              select new { s.Name, GoodStudent = s.AverageMark > 8};

            //var query = students.Where(a => (a.AverageMark > 8) ? a = "GoodStudent" : true);

            var fiveLetters = from s in students
                              where s.Name.Length > 5
                              select new { s.Id, s.Name, BadStatus = s.AverageMark < 5, GoodStatus = s.AverageMark > 8, OkStatus = s.AverageMark > 5 };

            foreach (var student in fiveLetters)
            {
                Console.WriteLine("Id={0}, Name={1}", student.Id, student.Name);
            }

            var data = from student in students
                       where student.Name.Length > 5
                       select new { student.Id, student.Name, Status = GetStatusFromMark(student.AverageMark)}
                       into studentStatusObject
                       group studentStatusObject by studentStatusObject.Status;

            
        }
        private static StudentStatus GetStatusFromMark(double AverageMark)
        {
            if (AverageMark < 5)
            {
                return StudentStatus.Bad;
            }
            if (AverageMark > 8)
            {
                return StudentStatus.Good;
            }
            return StudentStatus.Ok;
        }
    }
}
