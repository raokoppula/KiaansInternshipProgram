using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblUserAccount")]
    public class UserAccount
    {
        //[Key]
        [Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAccountID { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        [Required]
        public int UserAccountTypeID { get; set; }

        [ForeignKey("UserAccountTypeID")]
        public virtual UserAccountType UserAccountType { get; set; }

        public virtual CareerResume CareerResume { get; set; }

        public UserAccount()
        {
            
        }
    }

    //TODO: UserAccount -> Dept
    //UserAccountType - > EMP

    //public enum UserAccountTypeEnum
    //{
    //    JobAspirant,
    //    Intern,
    //    CorporateTrainingTaker,
    //    EmployerServicesUser,
    //    KiaansEmployee
    //}
}