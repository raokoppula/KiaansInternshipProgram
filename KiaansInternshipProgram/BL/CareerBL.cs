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

        public void UploadResume(CareerResume careerResume)
        {
            //TODO
            using (var dbContext = new InternshipDbContext())
            {
                dbContext.CareerResumes.Add(careerResume);
                dbContext.SaveChanges();
            }
        }
    }
}