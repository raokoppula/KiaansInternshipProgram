using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblJobPost")]
    public class JobPost
    {
        //[Key]
        [Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobPostID { get; set; }
        
        [Required]
        public int JobTypeID { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [Required]
        public int JobLocationID { get; set; }

        [Required]
        public int JobPostSkillSetID { get; set; }

        public string JobDescription { get; set; }

        public bool IsCompanyNameHidden { get; set; }
        public bool IsActive { get; set; }

        public int PostedByID { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("JobTypeID")]
        public virtual JobType JobType { get; set; }

        [ForeignKey("JobLocationID")]
        public virtual JobLocation JobLocation { get; set; }

        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }

        [ForeignKey("PostedByID")]
        public virtual PostedBy PersonPostedJobs { get; set; }

        [ForeignKey("JobPostSkillSetID")]
        public virtual JobPostSkillSet JobPostSkillSet { get; set; }
    }
}