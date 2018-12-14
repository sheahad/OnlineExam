using AutoMapper;
using OnlineExam.App.Models;
using OnlineExam.BLL.BLL;
using OnlineExam.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineExam.App.Controllers
{
    public class CourseController : Controller
    {
        CoursManager _courseManager = new CoursManager();
        OrganizationManager _organizationManager=new OrganizationManager();
        TrainerManager _trainerManager=new TrainerManager();

        TagManager _tagManager=new TagManager();
        public string message="";
        //
        // GET: /Course/
        [HttpGet]
        public ActionResult Save()
        {
            var model = new CourseCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() {Value = c.Id.ToString(), Text = c.Name}).ToList();

            model.Tags=_tagManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.TrainerSelectListItems = _trainerManager.GetAll().ToList();

            return View(model);
             
        }

        [HttpPost]
        public ActionResult Save(CourseCreateViewModel model)
        {
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                 .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            try
            {
                var course = Mapper.Map<Course>(model);
                bool isSaved = _courseManager.Add(course);

                if (isSaved)
                {
                    message = "Saved Successfully!";
                        ViewBag.SMsg = message;
                }
                else
                {
                    message = "Saved Failed!";
                    ViewBag.EMsg = message;
                }

                return View(model);
            }
            catch (Exception ex)
            {
                message = "Saved Failed!";
                ViewBag.EMsg = message;
            }
            return View(model);
        }

        public ActionResult CourseInformation()
        {
            var model = new CourseCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.Tags = _tagManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            
            model.TrainerSelectListItems = _trainerManager.GetAll().ToList();

            return View(model);
        }


        public JsonResult IsNameExist(string name)
        {
            var data = _courseManager.GetAll().FirstOrDefault(c => c.Name.ToLower().Equals(name.ToLower()));
            if (data != null)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }


            return Json(false, JsonRequestBehavior.AllowGet);
        }
	}
}