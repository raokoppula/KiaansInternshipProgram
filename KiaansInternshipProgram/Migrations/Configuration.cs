namespace KiaansInternshipProgram.Migrations
{
    using KiaansInternshipProgram.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KiaansInternshipProgram.DAL.InternshipDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "KiaansInternshipProgram.DAL.InternshipDbContext";
        }

        protected override void Seed(KiaansInternshipProgram.DAL.InternshipDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.JobTypes.AddOrUpdate(x => x.JobTypeID,
                new JobType() { JobTypeName = "Permanent", Description ="permanent position"},
                new JobType() { JobTypeName = "Contract", Description="contract position"},
                new JobType() { JobTypeName = "Parttime", Description="parttime position"}
            );

            context.Companies.AddOrUpdate(x => x.CompanyID,
               new Company() { Name = "Wipro", Description = "wipro ltd" },
               new Company() { Name = "TCS", Description = "tcs ltd" },
               new Company() { Name = "Infosys", Description = "infosys ltd" },
               new Company() { Name = "Dell", Description = "dell interational pvt ltd" }
           );

            context.JobLocations.AddOrUpdate(x => x.JobLocationID,
               new JobLocation() { StreetAddress = "Madhapur", City = "Hyderabad", State="Telangana", Country="India", Zip="500001" },
               new JobLocation() { StreetAddress = "Whitefield", City = "Bengaluru", State = "Karnataka", Country = "India", Zip = "560056" },
               new JobLocation() { StreetAddress = "Mangalagiri", City = "Amaravati", State = "Andhra Pradesh", Country = "India", Zip = "530001" },
               new JobLocation() { StreetAddress = "Adayaar", City = "Chennai", State = "Tamilnadu", Country = "India", Zip = "400001" }
           );

            context.JobPostSkillsets.AddOrUpdate(x => x.JobPostSkillSetID,
              new JobPostSkillSet() { SkillName = ".NET", Description = ".net" },
              new JobPostSkillSet() { SkillName = "Java", Description = "java" },
              new JobPostSkillSet() { SkillName = "AngularJS", Description = "angularjs" },
              new JobPostSkillSet() { SkillName = "Oracle", Description = "oracle" }
          );
        }
    }
}
