using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblCareerResume")]
    public class CareerResume
    {
        //[Key]
        [Required]
        public int CareerResumeID { get; set; }

        public string ResumeName { get; set; }

        [Required]
        public int UserAccountID { get; set; }

        [ForeignKey("UserAccountID")]
        public virtual UserAccount UserAccount { get; set; }

    }
}