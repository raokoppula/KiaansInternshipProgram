using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.Models
{
    [Table("tblUserAccountType")]
    public class UserAccountType
    {
        //[Key]
        [Required]
        public int UserAccountTypeID { get; set; }

        public string UserAccountTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserAccount> UserAccounts { get; set; }

        public UserAccountType()
        {
            UserAccounts = new HashSet<UserAccount>();
        }
    }
}