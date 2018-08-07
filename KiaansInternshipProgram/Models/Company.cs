using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblCompany")]
    public class Company
    {
        [Key]
        //[Required]
        public int CompanyID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }

        public Company()
        {
            JobPosts = new HashSet<JobPost>();
        }
    }
}