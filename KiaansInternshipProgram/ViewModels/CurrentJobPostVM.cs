using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.ViewModels
{
    public class CurrentJobPostVM
    {
        public int JobPostID { get; set; }
        public bool IsCompanyNameHidden { get; set; }
        public DateTime CreatedDate { get; set; }
        public string JobDescription { get; set; }
        public bool IsActive { get; set; }

        public string JobTypeName { get; set; }
        public string JobLocationName { get; set; }
        public string CompanyName { get; set; }
        public string PostedByName { get; set; }
        public string SkillSetName { get; set; }

        //public virtual IEnumerable<JobType> JobTypes { get; set; }
        //public virtual IEnumerable<JobLocation> JobLocations { get; set; }
        //public virtual IEnumerable<Company> Companies { get; set; }
        //public virtual IEnumerable<PostedBy> PersonPostedJobs { get; set; }
        //public virtual IEnumerable<JobPostSkillSet> JobPostSkillSets { get; set; }
    }
}