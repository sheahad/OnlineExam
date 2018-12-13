using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using OnlineExam.App.Models;
using OnlineExam.BLL.BLL;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Controllers
{
    public class LogInController : Controller
    {
        UserManager _userManager=new UserManager();
        //
        // GET: /LogIn/
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            //if user is valid user
            try
            {
            
                var user = Mapper.Map<User>(model);

                if (ModelState.IsValid)
                {

                }
            }
            catch (Exception)
            {
                
                throw;
            }

          


            FormsAuthentication.SetAuthCookie(model.UserName,false);
            return RedirectToAction("Index", "Home");
            

        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
	}
}