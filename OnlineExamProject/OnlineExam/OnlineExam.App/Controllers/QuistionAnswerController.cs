using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExam.App.Models;
using OnlineExam.BLL.BLL;

namespace OnlineExam.App.Controllers
{
    public class QuistionAnswerController : Controller
    {
        OrganizationManager _organizationManager = new OrganizationManager();
        CoursManager _coursManager = new CoursManager();
        ExamManager _examManager = new ExamManager();
        QuestionAnswerCreateViewModel model = new QuestionAnswerCreateViewModel();
        
        //
        // GET: /QuistionAnswer/
        [HttpGet]
        public ActionResult Save()
        {
            var model = new QuestionAnswerCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
              .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            model.ExamSelectListItems = _examManager.GetAll()
              .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            return View(model);
        }
        [HttpPost]
        public ActionResult Save(QuestionAnswerCreateViewModel model)
        {
            
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
              .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            model.ExamSelectListItems = _examManager.GetAll()
              .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            return View(model);
        }

        public JsonResult GetCourseByOrganizationId(int organizationId)
        {
            var dataList = _coursManager.GetAll();
            dataList = dataList.Where(c => c.OrganizationId == organizationId).ToList();
            var jsonResult = dataList.Select(c => new {Id= c.Id, Name= c.Name });
            return Json(jsonResult, JsonRequestBehavior.AllowGet);

        }
        public JsonResult GetExamByCourseId(int courseId)
        {
            var dataList = _examManager.GetAll();
            dataList = dataList.Where(c => c.CourseId == courseId).ToList();
            var jsonResult = dataList.Select(c => new { Id = c.Id, Name = c.Code });
            return Json(jsonResult, JsonRequestBehavior.AllowGet);

        }
    }
}