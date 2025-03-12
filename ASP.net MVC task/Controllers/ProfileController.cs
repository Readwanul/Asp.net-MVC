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
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Ref()
        {
            return View();
        }
    }
}