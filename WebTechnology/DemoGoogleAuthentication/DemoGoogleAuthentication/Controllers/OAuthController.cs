using DemoGoogleAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoGoogleAuthentication.Controllers
{
    public class OAuthController : Controller
    {
        // GET: OAuth
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignOut()
        {
            this.Session.Clear();
            return View("Index");
        }

        [HttpPost]
        public ActionResult OAuth(OAuthAction data)
        {
            var result = data.Execute();
            if(result == true)
            {
                this.Session["userid"] = data.GetUser().UserId;
                this.Session.Timeout = 5;
                return Json(new { IsSuccess = true });
            }
            return Json(new { IsSuccess = false });
        }
    }
}