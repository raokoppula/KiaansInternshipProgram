using KiaansInternshipProgram.BL;
using KiaansInternshipProgram.Models;
using KiaansInternshipProgram.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaansInternshipProgram.Controllers
{
    public class CompanyZoneController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EmployerLogin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegisterEmployer()
        {
            return View();
        }

        [HttpGet]
        public ActionResult JobPostingServices()
        {           
            CompanyBL companyBL = new CompanyBL();

            JobPostServicesVM jobpostServicesVM = new JobPostServicesVM();
            jobpostServicesVM.JobTypes = companyBL.GetJobTypes();
            jobpostServicesVM.Companies = companyBL.GetCompanies();
            jobpostServicesVM.JobLocations = companyBL.GetJobLocations();
            jobpostServicesVM.JobPostSkillSets = companyBL.GetSkillsets();

            return View(jobpostServicesVM);
        }

        [HttpPost]
        public void JobPostingServices(JobPost jobPost)
        {
            JobPost job = new JobPost();
            job.JobTypeID = Convert.ToInt32(Request.Form["JobType"]);
            job.CompanyID = Convert.ToInt32(Request.Form["Company"]);
            job.JobLocationID = Convert.ToInt32(Request.Form["JobLocation"]);
            job.JobPostSkillSetID = Convert.ToInt32(Request.Form["JobPostSkillSet"]);

            job.JobDescription = Request.Form["JobDescription"];

            if (Request.Form["IsActive"] == "true")
                job.IsActive = true;
            else if (Request.Form["IsActive"] == "true")
                job.IsActive = false;

            if (Request.Form["IsCompanyNameHidden"] == "true")
                job.IsCompanyNameHidden = true;
            else if (Request.Form["IsCompanyNameHidden"] == "true")
                job.IsCompanyNameHidden = false;

            job.CreatedDate = DateTime.Now;
            job.PostedByID = 1; //1. Admin, 2. User for now Hotcoded //TODO:

            CompanyBL companyBL = new CompanyBL();
            companyBL.SaveJobPost(job);
        }

        [HttpGet]
        public ActionResult ResumeDatabaseAccess()
        {
            return View();
        }
    }
}