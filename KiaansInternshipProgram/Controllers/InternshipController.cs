using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaansInternshipProgram.Controllers
{
    public class InternshipController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InternshipPrograms()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ApplyInternship(Course mySelectedCourse)
        {
            return View();
        }
    }
}