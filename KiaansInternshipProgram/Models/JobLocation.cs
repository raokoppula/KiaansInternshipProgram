using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblJobLocation")]
    public class JobLocation
    {
        //[Key]
        [Required]
        public int JobLocationID { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }

        public JobLocation()
        {
            JobPosts = new HashSet<JobPost>();
        }
    }
}