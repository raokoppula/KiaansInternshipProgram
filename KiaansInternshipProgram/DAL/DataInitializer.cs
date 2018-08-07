using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.DAL
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<InternshipDbContext>
    {
        protected override void Seed(InternshipDbContext context)
        {
            var jobTypes = new List<JobType>
            {
            new JobType {JobTypeID=21, JobTypeName="Permanent", Description="permanent position"},
            new JobType {JobTypeID=22, JobTypeName="Contract", Description="contract position"},
            new JobType {JobTypeID=23, JobTypeName="Parttime", Description="parttime position"}
            };

            var postedByPersons = new List<PostedBy>
            {
            new PostedBy {PostedByID=11, PostedByName="Rama"},
            new PostedBy {PostedByID=12, PostedByName="Sita"},
            new PostedBy {PostedByID=13, PostedByName="Ganesh"}
            };

            var jobPostSkillSets = new List<JobPostSkillSet>
            {
            new JobPostSkillSet {JobPostSkillSetID=31, SkillName=".NET", Description=".NET group"},
            new JobPostSkillSet {JobPostSkillSetID=32, SkillName="Java", Description="Java group"},
            new JobPostSkillSet {JobPostSkillSetID=33, SkillName="Sql Server", Description="Sql Server group"},
            new JobPostSkillSet {JobPostSkillSetID=34, SkillName="AngularJS", Description="Angular JS group"}
            };

            var jobLocations = new List<JobLocation>
            {
            new JobLocation {JobLocationID=41, StreetAddress="Madhapur", City="Hyderabad", State="Telangana", Country="India", Zip="500034"},
            new JobLocation {JobLocationID=42, StreetAddress="Whitefield", City="Bengaluru", State="Karnataka", Country="India", Zip="560056"},
            new JobLocation {JobLocationID=43, StreetAddress="Mangalagiri", City="Amaravati", State="Andhra Pradesh", Country="India", Zip="530021"},
            new JobLocation {JobLocationID=44, StreetAddress="Adayar", City="Chennai", State="Tamilnadu", Country="India", Zip="600432"}
            };

            var companies = new List<Company>
            {
            new Company {CompanyID=51, Name="Google", Description="Google Inc."},
            new Company {CompanyID=52, Name="Microsoft", Description="Microsoft Inc."},
            new Company {CompanyID=53, Name="TCS", Description="TCS Ltd."},
            new Company {CompanyID=54, Name="Wipro", Description="Wipro Ltd."},
            new Company {CompanyID=55, Name="Mahindra Satyam", Description="Mahindra Satyam Ltd."}
            };

            context.SaveChanges();
        }
    }
}