using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblPostedBy")]
    public class PostedBy
    {
        //[Key]
        [Required]
        public int PostedByID { get; set; }

        public string PostedByName { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }

        public PostedBy()
        {
            JobPosts = new HashSet<JobPost>();
        }
    }
}