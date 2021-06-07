using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page  - The Tech Acadmey";

            return View();
        }
        public ActionResult Instructors()
        {
            return View();
        }
        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"

            };
            return View(dayTimeInstructor);
        }
        public ActionResult Instructor()
        {
            return View();
        }
        
    }
}