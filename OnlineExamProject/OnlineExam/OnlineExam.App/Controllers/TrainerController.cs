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
    public class TrainerController : Controller
    {
         TrainerManager _trainerManager = new TrainerManager();
        OrganizationManager _organizationManager=new OrganizationManager();
        BatchManager _batchManager=new BatchManager();
        CoursManager _coursManager=new CoursManager();
        CityManager _cityManager=new CityManager();
        CountryManager _countryManager=new CountryManager();

         public string message = "";
        //
        // GET: /Trainer/
        [HttpGet]
        public ActionResult Save()
        {
            var model = new TrainerCreateViewModel();
            model.OrganizationSelectListItems = _organizationManager.GetAll()
                .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            model.BatchSelectListItems = _batchManager.GetAll()
                .Select(c => new SelectListItem() {Value = c.Id.ToString(), Text = c.BatchNo}).ToList();

            model.CourseSelectListItems = _coursManager.GetAll()
                .Select(c => new SelectListItem() {Value = c.Id.ToString(), Text = c.Code}).ToList();

            model.CityListItemList = _cityManager.GetAll()
                .Select(c => new SelectListItem() {Value = c.Id.ToString(), Text = c.Name}).ToList();

            model.CountryListItem = _countryManager.GetAll()
         .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();

            return View(model);


        }
        [HttpPost]
        public ActionResult Save(TrainerCreateViewModel model)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    var trainer = Mapper.Map<Trainer>(model);
                    bool isSaved = _trainerManager.Add(trainer);

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
            var model = _trainerManager.GetAll().ToList();
            return View(model);
        }
	}
}