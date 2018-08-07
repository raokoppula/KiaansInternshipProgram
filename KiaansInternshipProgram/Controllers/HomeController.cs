using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaansInternshipProgram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "KIAAN Internship programme.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "KIAAN Internship";

            return View();
        }
    }
}