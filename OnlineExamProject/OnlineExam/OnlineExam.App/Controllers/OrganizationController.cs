using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineExam.App.Controllers
{
    [Authorize]
    public class OrganizationController : Controller
    {
        //
        // GET: /Organization/
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Save()
        {
            ViewBag.UserName = HttpContext.User.Identity.Name;
            
            return View();
        }
	}
}