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
    public class ParticipantsController : Controller
    {
        ParticipantManager _participantManager = new ParticipantManager();
        OrganizationManager _organizationManager = new OrganizationManager();
        BatchManager _batchManager = new BatchManager();
        CoursManager _coursManager = new CoursManager();
        CityManager _cityManager = new CityManager();
        CountryManager _countryManager = new CountryManager();

        Organization organization=new Organization();
        Course course=new Course();

        public string message = "";
        
        [HttpGet]
        public ActionResult Save()
        {
            var model = new ParticipantCreateViewModel();
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

            return View(model);


        }
        [HttpPost]
        public ActionResult Save(ParticipantCreateViewModel model)
        {
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

            try
            {
                if (ModelState.IsValid)
                {
                    var participant = Mapper.Map<Participant>(model);
                    bool isSaved = _participantManager.Add(participant);

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

        public ActionResult Search()
        {
            var model = _participantManager.GetAll().ToList();
            return View(model);
        }

        public JsonResult GetAutoCode()
        {
            var autoCode ="PAR_"+ organization.Id + course.Code + DateTime.Now.Millisecond + "101";
            return Json(autoCode, JsonRequestBehavior.AllowGet);
        }
    }
}