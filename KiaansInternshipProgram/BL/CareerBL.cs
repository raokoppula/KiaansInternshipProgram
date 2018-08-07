using KiaansInternshipProgram.DAL;
using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.BL
{
    public class CareerBL
    {
        public virtual IEnumerable<Career> Careers { get; set; }

        public void UploadResume(Career myCareer)
        {
            //TODO
            //InternshipDbContext internshipDbContext = new InternshipDbContext();
            //internshipDbContext.Careers.Add(myCareer);
            //internshipDbContext.SaveChanges();
        }
    }
}