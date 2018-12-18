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
    public class QuistionAnswerController : Controller
    {
        OrganizationManager _organizationManager = new OrganizationManager();
        CoursManager _coursManager = new CoursManager();
        ExamManager _examManager = new ExamManager();
        QuestionAnswerCreateViewModel model = new QuestionAnswerCreateViewModel();
        QuestionManager _questionManager = new QuestionManager();
        
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

            model.Questions = _questionManager.GetAll();

            return View(model);
        }
        [HttpPost]
//        [ValidateAntiForgeryToken]
        public ActionResult Save(QuestionAnswerCreateViewModel model)
        {
            string message ="";
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
              .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            model.ExamSelectListItems = _examManager.GetAll()
              .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();
            try
            {
                if (ModelState.IsValid && model.Answers != null && model.Answers.Count() > 0)
                {
                    var question = Mapper.Map<Question>(model);

                    bool isSaved = _questionManager.Add(question);

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

            }
            catch (Exception ex)
            {

                message = "Saved Faild!";
                ViewBag.EMsg = message;
            }
            
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

        public JsonResult GetQuestionByXxamId(int examId)
        {
            var dataList = _questionManager.GetAll();
            dataList = dataList.Where(c => c.ExamId == examId).ToList();
            var jsonResult = dataList.Select(c => new {c.QOrder, c.Question1, c.QuestionType, Option = c.Answers });
            return Json(jsonResult, JsonRequestBehavior.AllowGet);

        }
    }
}