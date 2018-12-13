using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using OnlineExam.App.Models;
using OnlineExam.BLL.BLL;
using OnlineExam.Models;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Controllers
{
    public class ExamController : Controller
    {
         OrganizationManager _organizationManager = new OrganizationManager();
        CoursManager _coursManager=new CoursManager();
         Organization _organization = new Organization();
         ExamManager _examManager = new ExamManager();

        public string message = "";
        //
        // GET: /Organization/

        [HttpGet]
        public ActionResult Save()
        {
            //ViewBag.UserName = User.Identity.Name;
            //var model = _organizationManager.GetAll().ToList();


            var model = new ExamCreateViewModel();

            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            model.ExamTypeListItems = _examManager.GetAll()
                .Select(c => new SelectListItem() {Value = c.Id.ToString(), Text = c.ExamType}).ToList();

            //model.OrganizationItemList = _organizationManager.GetAll();

            return View(model);

        }

        [HttpPost]
        public ActionResult Save(ExamCreateViewModel model)
        {
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            //ViewBag.UserName = User.Identity.Name;
            try
            {
                if (ModelState.IsValid)
                {
                    var exam = Mapper.Map<Exam>(model);
                    bool isSaved = _examManager.Add(exam);

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
                message = Utility.GetModelStateError(ModelState);
                ViewBag.EMsg = message;
            }
            catch (Exception)
            {
                message = "Saved Faild!";
                ViewBag.EMsg = message;

            }

            return View(model);

        }

    }
}