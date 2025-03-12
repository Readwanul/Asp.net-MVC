using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.net_MVC_task.Controllers;
using ASP.net_MVC_task.Models;

namespace ASP.net_MVC_task.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Home()
        {
            Profile p = new Profile();
            p.Depertment = "CSE";
            p.Id = 45887;
            p.Semester = 11;
            p.Name = "Readwan";
            p.Mail = "21-45887-3@student.aiub.edu";
            return View(p);
        }

        public ActionResult Education()
        {
            var Ed1 = new Education()
            {
                Institution = "Ashuganj Sarkarkhana School & College",
                Level = "SSC",
                Years = "2016-2018"
            };
            var Ed2 = new Education()
            {
                Institution = "Ashuganj Sarkarkhana School & College",
                Level = "HSC",
                Years = "2018-2020"
            };
            var Ed3 = new Education()
            {
                Institution = "American International University-Bangladesh",
                Level = "CSE",
                Years = "2021-2025"
            };

            Education[] E = new Education[] { Ed1, Ed2, Ed3 };

            return View(E);
        }

        public ActionResult Projects()
        {
            var p1 = new Project()
            {
                Title = "Foodcourt Management System",
                Course="Object Oriented Programming",
                Semester=2
            };
            var p2 = new Project()
            {
                Title = "University Admission Management System",
                Course = "Introduction To Database",
                Semester = 3
            };
            var p3 = new Project()
            {
                Title = "Bookshop Management System",
                Course = "Object Oriented Programming 2",
                Semester = 5
            };
            var p4 = new Project()
            {
                Title = "Houserent Management System",
                Course = "Advanceed Web Technology",
                Semester = 10
            };
            var p5 = new Project()
            {
                Title = "Sentiment Analysis System",
                Course = "Machine Learning",
                Semester = 10
            };


            Project[] P = new Project[] { p1, p2, p3, p4, p5 };
            return View(P);
        }

        public ActionResult Ref()
        {
            return View();
        }
    }
}