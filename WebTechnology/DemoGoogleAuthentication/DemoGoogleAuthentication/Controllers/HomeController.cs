using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Apis;
using Google.Apis.Auth.OAuth2;

namespace DemoGoogleAuthentication.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Offline(string code)
        {
            if(Request.Headers["X-Requested-With"] == null)
            {
                return Json(false);
            }
            GoogleClientSecrets clientSecrets = new GoogleClientSecrets();
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}