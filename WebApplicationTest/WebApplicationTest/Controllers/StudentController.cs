using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class StudentController : Controller
    {

        static private List<Student> students = new List<Student>()
        {
            new Student(){Id = 0, Age = 10, City = "Vilnius", Name = "Petras", Score = 5.5, IsGettingTuition= true },
            new Student(){Id = 1, Age = 61, City = "Kaunas", Name = "Kestas", Score = 6.5, IsGettingTuition= false },
            new Student(){Id = 2, Age = 25, City = "Vilnius", Name = "Ona", Score = 9.5, IsGettingTuition= true }
        };


        //C - CREATE
        //R - READ
        //U - UPDATE
        //D - DELETE

        // GET: Student
        public ActionResult Index()
        {
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View(students.Where(s => s.Id == id).SingleOrDefault());
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                students.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(student);
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View(students.Where(s => s.Id == id).SingleOrDefault());
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student editedStudent)
        {
            try
            {

                Student student = students.Where(s => s.Id == id).SingleOrDefault();
                student.Name = editedStudent.Name;
                student.Score = editedStudent.Score;
                student.City = editedStudent.City;
                student.Age = editedStudent.Age;
                student.IsGettingTuition = editedStudent.IsGettingTuition;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(editedStudent);
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = students.Where(s => s.Id == id).SingleOrDefault();
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VerifyDelete(int id)
        {
            try
            {
                students.RemoveAll(s => s.Id == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(students.Where(s => s.Id == id).SingleOrDefault());
            }
        }
    }
}