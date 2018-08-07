using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblJobPostActivity")]
    public class JobPostActivity
    {
        //[Key]
        [Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobPostActivityID { get; set; }

        public DateTime ApplyDate { get; set; }
                
        public virtual JobPost JobPost { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}