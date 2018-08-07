using KiaansInternshipProgram.BL;
using KiaansInternshipProgram.DAL;
using KiaansInternshipProgram.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaansInternshipProgram.Controllers
{
    public class ResumeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadResume(Career career, HttpPostedFileBase file)
        {
            if (file == null)
            {
                ModelState.AddModelError("CustomError", "Please select CV");
                return View("Index");
            }

            if (!(file.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" ||
                file.ContentType == "application/pdf"))
            {
                ModelState.AddModelError("CustomError", "Only .docx and .pdf file allowed");
                return View("Index");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    file.SaveAs(Path.Combine(Server.MapPath("~/UploadResume"), fileName));
                    
                    //TODO for CV upload to DB - Start
                    CareerBL careerBL = new CareerBL();
                    careerBL.UploadResume(career);
                        //careerBL.Resume = fileName;
                        //internshipDBContext.Careers.Add(career);
                        //internshipDBContext.SaveChanges();
                    //End

                    ModelState.Clear();
                    career = null;
                    ViewBag.Message = "Successfully Done";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error! Please try again";
                    return View();
                }
            }
            return View();
        }
    }
}