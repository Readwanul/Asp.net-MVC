using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_practice.EF;

namespace Task_practice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentEntities db = new StudentEntities();
            var studentList = db.StudentInfoes.ToList();
            return View(studentList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(StudentInfo S)
        {
            StudentEntities db = new StudentEntities();
            db.StudentInfoes.Add(S);
            db.SaveChanges();
            TempData["message"] = "Student Created Successfully";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            StudentEntities db = new StudentEntities();
            var student = db.StudentInfoes.Find(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(StudentInfo S)
        {
            StudentEntities db = new StudentEntities();
            var student = db.StudentInfoes.Find(S.Id);
            student.Name = S.Name;
            student.Email = S.Email;
            student.DateOfBirth = S.DateOfBirth;
            db.SaveChanges();
            TempData["message"] = "Student Updated Successfully";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            StudentEntities db = new StudentEntities();
            var student = db.StudentInfoes.Find(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Delete(StudentInfo S)
        {
            StudentEntities db = new StudentEntities();
            var student = db.StudentInfoes.Find(S.Id);
            db.StudentInfoes.Remove(student);
            db.SaveChanges();
            TempData["message"] = "Student Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}