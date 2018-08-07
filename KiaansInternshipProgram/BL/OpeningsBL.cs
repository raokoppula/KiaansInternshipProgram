using KiaansInternshipProgram.DAL;
using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.BL
{
    public class OpeningsBL
    {
        public List<JobPost> GetCurrentJobPosts()
        {
            using (var dbContext = new InternshipDbContext())
            {
                return dbContext.JobPosts.ToList();
            }
        }
    }
}