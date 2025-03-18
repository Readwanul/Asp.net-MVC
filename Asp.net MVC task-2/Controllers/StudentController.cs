using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.net_MVC_task_2.Models;

namespace Asp.net_MVC_task_2.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Index(Student s)
        {
            if (ModelState.IsValid)
            {
                return View(s);
            }
            return View(new Student());
        }
    }
}