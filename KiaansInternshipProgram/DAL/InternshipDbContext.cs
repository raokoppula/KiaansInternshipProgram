using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.DAL
{
    public class InternshipDbContext: DbContext
    {
        //public virtual DbSet<Course> Courses{ get; set; }
        //public virtual DbSet<Intern> Interns { get; set; }
        //public virtual DbSet<Career> Careers { get; set; }

        public virtual DbSet<JobPost> JobPosts { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<JobLocation> JobLocations { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<PostedBy> PersonPostedJobs { get; set; }
        public virtual DbSet<JobPostSkillSet> JobPostSkillsets { get; set; }
        public virtual DbSet<JobPostActivity> JobPostActivities { get; set; }
        public virtual DbSet<CareerResume> CareerResumes { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        public InternshipDbContext() :  base("InternshipDbContext")
        {
          
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobType>()
                       .HasMany(e => e.JobPosts)
                       .WithRequired(e => e.JobType)
                       .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobLocation>()
                        .HasMany(e => e.JobPosts)
                        .WithRequired(e => e.JobLocation)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                       .HasMany(e => e.JobPosts)
                       .WithRequired(e => e.Company)
                       .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostedBy>()
                       .HasMany(e => e.JobPosts)
                       .WithRequired(e => e.PersonPostedJobs)
                       .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobPostSkillSet>()
                       .HasMany(e => e.JobPosts)
                       .WithRequired(e => e.JobPostSkillSet)
                       .WillCascadeOnDelete(false);

            //TODO: need to write 2 entries for UserAccountType and CareerResume
            //TODO: Need to verify the below mapping once again
            modelBuilder.Entity<UserAccountType>()
                      .HasMany(e => e.UserAccounts)
                      .WithRequired(e => e.UserAccountType)
                      .WillCascadeOnDelete(false);

            //TODO: Need to verify the below mapping once again
            modelBuilder.Entity<CareerResume>()
                      .HasOptional(e => e.UserAccount)
                      .WithRequired(e => e.CareerResume)
                      .WillCascadeOnDelete(false);

            //modelBuilder.Entity<UserAccount>()
            //          .HasOptional(e => e.CareerResume)
            //          .WithRequired(e => e.UserAccount)
            //          .WillCascadeOnDelete(false);
        }
    }
}