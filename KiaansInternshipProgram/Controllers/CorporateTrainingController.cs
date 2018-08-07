using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaansInternshipProgram.Controllers
{
    /// <summary>
    /// Corporate training for the skills, 
    /// </summary>
    public class CorporateTrainingController : Controller
    {
        // GET: CorporateTraining
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CommuncationSkills()
        {
            return View();
        }

        public ActionResult LeadershipSkills()
        {
            return View();
        }

        public ActionResult BehaviorSkills()
        {
            return View();
        }

        public ActionResult SalesSkills()
        {
            return View();
        }

        public ActionResult HRSkills()
        {
            return View();
        }
    }
}