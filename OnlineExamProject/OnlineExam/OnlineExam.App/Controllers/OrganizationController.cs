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
    //[Authorize]
    public class OrganizationController : Controller
    {
        OrganizationManager _organizationManager = new OrganizationManager();

        public string message = "";
        //
        // GET: /Organization/
       
            [HttpGet]
        public ActionResult Save()
        {
            //ViewBag.UserName = User.Identity.Name;

            return View();
        }
        [HttpPost]
        public ActionResult Save(OrganizationCreateViewModel model)
        {
<<<<<<< HEAD
            model.CreateById = 2;
            model.CreateDate = DateTime.Now;
=======
            //model.Status = "A";
            model.CreateById = 1;
            model.CreateDate = DateTime.Now;
            
>>>>>>> 71c14148bf144dcbe9e14381223d0d83c558fdb2
            ViewBag.UserName = User.Identity.Name;
            try
            {
                if (ModelState.IsValid)
                {
                    var organization = Mapper.Map<Organization>(model);
                    bool isSaved = _organizationManager.Add(organization);

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
            catch (Exception )
            {
                message = "Saved Faild!";
                ViewBag.EMsg = message;
               
            }

            return View(model);
<<<<<<< HEAD
        }

        public JsonResult IsNameExist(string name)
        {
            var data = _organizationManager.GetAll().FirstOrDefault(c => c.Name.ToLower().Equals(name.ToLower()));
            if (data != null)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }


            return Json(false, JsonRequestBehavior.AllowGet);
=======
>>>>>>> 71c14148bf144dcbe9e14381223d0d83c558fdb2
        }
	}
}