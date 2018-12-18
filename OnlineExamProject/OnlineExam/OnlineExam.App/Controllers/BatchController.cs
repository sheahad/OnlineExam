using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using OnlineExam.App.Models;
using OnlineExam.BLL.BLL;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Controllers
{
    public class BatchController : Controller
    {
        CoursManager _courseManager = new CoursManager();
        OrganizationManager _organizationManager = new OrganizationManager();
        TrainerManager _trainerManager = new TrainerManager();
        BatchManager _batchManager = new BatchManager();
        CoursManager _coursManager = new CoursManager();
        CityManager _cityManager = new CityManager();
        CountryManager _countryManager = new CountryManager();
        ExamManager _examManager = new ExamManager();

        ParticipantManager _participantManager=new ParticipantManager();

        TagManager _tagManager = new TagManager();

         string message = "";
        //
        // GET: /Batch/
    [HttpGet]
        public ActionResult Save()
        {
            
        var model=new BatchCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                 .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            model.CourseSelectListItems = _organizationManager.GetAll()
                 .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
        return View(model);
        }
        [HttpPost]
        public ActionResult Save(BatchCreateViewModel model)
        {
             model.OrganizationSelectListItems = _organizationManager.GetAll()
                 .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            model.CourseSelectListItems = _organizationManager.GetAll()
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

        public ActionResult BatchView()
        {
            return View();
        }

        public PartialViewResult GetAddBatchExamPV()
        {
            var model = new BatchCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
            .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            model.CourseSelectListItems = _organizationManager.GetAll()
                 .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            return PartialView("~/Views/Shared/Batch/_AddBasicBatchInfo.cshtml", model);
        }

        public PartialViewResult GetAddParticipentCreatePV()
        {
            var model = new BatchCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.BatchSelectListItems = _batchManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.BatchNo }).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            model.CityListItemList = _cityManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.CountryListItem = _countryManager.GetAll()
         .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

          
            return PartialView("~/Views/Shared/Batch/_AddParticipentCreatePV.cshtml", model);
        }

        public PartialViewResult GetParticipentLoadPV()
        {
            var model = new BatchCreateViewModel();
            model.ParticipentListItem = _participantManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            return PartialView("~/Views/Shared/Batch/_ParticipentLoad.cshtml", model);
        }

        public PartialViewResult GetAddAddCourseTrainerPV()
        {
            var model = new BatchCreateViewModel();
            model.TrainerListItems = _trainerManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
            return PartialView("~/Views/Shared/Batch/_AssignTrainerLoadPv.cshtml", model);
        }

        public PartialViewResult GetAssginCourseTrainerPV() 
        {
            var model = new BatchCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.BatchSelectListItems = _batchManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.BatchNo }).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Code }).ToList();

            model.CityListItemList = _cityManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.CountryListItem = _countryManager.GetAll()
         .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            return PartialView("~/Views/Shared/Batch/_AddCourseTrainer.cshtml", model);
        }
           
        }
     

	}
