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
    public class OpeningsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCurrentJobPosts()
        {
            OpeningsBL openingsBL = new OpeningsBL();
            List<JobPost> jobPosts = openingsBL.GetCurrentJobPosts();

            List<CurrentJobPostVM> currentJobPostListVM = new List<CurrentJobPostVM>();
            foreach(JobPost post in jobPosts)
            {
                CurrentJobPostVM jobPostVM = new CurrentJobPostVM();
                jobPostVM.JobPostID = post.JobPostID;
                jobPostVM.IsCompanyNameHidden = post.IsCompanyNameHidden;
                jobPostVM.CreatedDate = post.CreatedDate;
                jobPostVM.JobDescription = post.JobDescription;
                jobPostVM.IsActive = post.IsActive;

                CompanyBL companyBL = new CompanyBL();

                var jobTypes = companyBL.GetJobTypes();
                var jobTypeNameFromQuery = (from s in jobTypes where s.JobTypeID == post.JobTypeID select new { JbTypeName = s.JobTypeName}).FirstOrDefault();
                jobPostVM.JobTypeName = jobTypeNameFromQuery?.JbTypeName;

                var jobLocations = companyBL.GetJobLocations();
                var jobLocationNameFromQuery = (from s in jobLocations where s.JobLocationID == post.JobLocationID select new { JbLocationeName = s.City }).FirstOrDefault();
                jobPostVM.JobLocationName = jobLocationNameFromQuery?.JbLocationeName;

                var jobCompanies = companyBL.GetCompanies();
                var jobCompanyNameFromQuery = (from s in jobCompanies where s.CompanyID == post.CompanyID select new { JbLCompanyName = s.Name }).FirstOrDefault();
                jobPostVM.CompanyName = jobCompanyNameFromQuery?.JbLCompanyName;

                var jobSkillsets = companyBL.GetSkillsets();
                var jobSkillsetNameFromQuery = (from s in jobSkillsets where s.JobPostSkillSetID == post.JobPostSkillSetID select new { JbLSkillsetName = s.SkillName }).FirstOrDefault();
                jobPostVM.SkillSetName = jobSkillsetNameFromQuery?.JbLSkillsetName;

                var jobPostedByPersons = companyBL.GetJobPostByPersons();
                var jobPostedByPersonNameFromQuery = (from s in jobPostedByPersons where s.PostedByID == post.PostedByID select new { JbLPostedByPersonName = s.PostedByName }).FirstOrDefault();
                jobPostVM.PostedByName = jobPostedByPersonNameFromQuery?.JbLPostedByPersonName;

                currentJobPostListVM.Add(jobPostVM);
            }

            return View("CurrentJobs", currentJobPostListVM);
        }

        public ActionResult ApplyJobs()
        {
            return View();
        }

        public ActionResult GetJobTypes()
        {
            //JobTypeBL jobTypeBL = new JobTypeBL();
            //jobTypeBL.GetJobTypes();
            return View();
        }

    }
}