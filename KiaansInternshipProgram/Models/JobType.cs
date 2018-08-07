using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblJobType")]
    public class JobType
    {
        //[Key]
        [Required]
        public int JobTypeID { get; set; }

        public string JobTypeName { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<JobPost> JobPosts { get; set; }

        public JobType()
        {
            JobPosts = new HashSet<JobPost>();
        }
    }

    //public enum JobTypeEnum
    //{
    //    Permanent,
    //    Contract,
    //    PartTime
    //}
}