using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace istanbulakademi_mvcders_1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentExamList()
        {
            return View();
        }
        public ActionResult LessonList()
        {
            return View();
        }

    }
}