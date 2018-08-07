using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblJobPostSkillset")]
    public class JobPostSkillSet
    {
        //[Key]
        [Required]
        public int JobPostSkillSetID { get; set; }

        public string SkillName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }

        public JobPostSkillSet()
        {
            JobPosts = new HashSet<JobPost>();
        }
    }
}