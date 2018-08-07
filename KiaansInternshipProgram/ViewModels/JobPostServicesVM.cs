using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaansInternshipProgram.ViewModels
{
    public class JobPostServicesVM
    {   
        public int JobPostID { get; set; }
        public bool IsCompanyNameHidden { get; set; }
        public DateTime CreatedDate { get; set; }
        public string JobDescription { get; set; }
        public bool IsActive { get; set; }

        public virtual JobType JobType { get; set; }
        //public virtual Enum JobType { get; set; }
        public virtual JobLocation JobLocation { get; set; }
        public virtual Company Company { get; set; }
        public virtual PostedBy PersonPostedJob { get; set; }
        public virtual JobPostSkillSet JobPostSkillSet { get; set; }

        public virtual IEnumerable<JobType> JobTypes { get; set; }
        public virtual IEnumerable<JobLocation> JobLocations { get; set; }
        public virtual IEnumerable<Company> Companies { get; set; }
        public virtual IEnumerable<PostedBy> PersonPostedJobs { get; set; }
        public virtual IEnumerable<JobPostSkillSet> JobPostSkillSets { get; set; }

    }
}