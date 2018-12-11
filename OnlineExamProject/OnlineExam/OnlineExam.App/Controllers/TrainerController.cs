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
         public string message = "";
        //
        // GET: /Trainer/
        [HttpGet]
        public ActionResult Save()
        {
            return View();
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
	}
}