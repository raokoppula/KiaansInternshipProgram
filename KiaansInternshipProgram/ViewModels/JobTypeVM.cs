using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiaansInternshipProgram.ViewModels
{
    public class JobTypeVM
    {
        public virtual List<JobType> JobTypes { get; set; }
    }
}