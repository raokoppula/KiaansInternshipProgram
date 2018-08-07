using KiaansInternshipProgram.DAL;
using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.BL
{
    public class CompanyBL
    {
        public List<JobType>GetJobTypes()
        {
            using (var dbContext = new InternshipDbContext())
            {
                return dbContext.JobTypes.ToList();
            }
        }

        public List<JobLocation> GetJobLocations()
        {
            using (var dbContext = new InternshipDbContext())
            {
                return dbContext.JobLocations.ToList();
            }
        }

        public List<Company> GetCompanies()
        {
            using (var dbContext = new InternshipDbContext())
            {
                return dbContext.Companies.ToList();
            }
        }

        public List<JobPostSkillSet> GetSkillsets()
        {
            using (var dbContext = new InternshipDbContext())
            {
                return dbContext.JobPostSkillsets.ToList();
            }
        }

        public List<PostedBy> GetJobPostByPersons()
        {
            using (var dbContext = new InternshipDbContext())
            {
                return dbContext.PersonPostedJobs.ToList();
            }
        }

        public void SaveJobPost(JobPost jobPost)
        {
            using (var dbContext = new InternshipDbContext())
            {
                if (jobPost.JobPostID == 0)
                {
                    dbContext.JobPosts.Add(jobPost);
                }
                else
                {
                    JobPost dbEntry = dbContext.JobPosts.Find(jobPost.JobPostID);
                    if (dbEntry != null)
                    {
                        JobType jbType = new JobType();
                        jbType.JobTypeID = jobPost.JobType.JobTypeID;
                        dbEntry.JobType = jbType;

                        Company comp = new Company();
                        comp.CompanyID = jobPost.Company.CompanyID;
                        dbEntry.Company = comp;

                        JobLocation jbLocation = new JobLocation();
                        jbLocation.JobLocationID = jobPost.JobLocation.JobLocationID;
                        dbEntry.JobLocation = jbLocation;

                        JobPostSkillSet jbPostSkillset = new JobPostSkillSet();
                        jbPostSkillset.JobPostSkillSetID = jobPost.JobPostSkillSet.JobPostSkillSetID;
                        dbEntry.JobPostSkillSet = jbPostSkillset;

                        dbEntry.JobDescription = jobPost.JobDescription;
                        dbEntry.IsActive = jobPost.IsActive;
                        dbEntry.IsCompanyNameHidden = jobPost.IsCompanyNameHidden;
                        dbEntry.PostedByID = 1;
                        dbEntry.CreatedDate = DateTime.Now;
                    }
                }
                dbContext.SaveChanges();
            }
        }
    }
}