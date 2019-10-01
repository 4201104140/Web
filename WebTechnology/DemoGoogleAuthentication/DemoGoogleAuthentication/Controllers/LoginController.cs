using DemoGoogleAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoGoogleAuthentication.Controllers
{
    public class LoginController : Controller
    {
        public GoogleUser user { get; set; }

        // GET: Login
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(GoogleUser user)
        {
            HttpContext.Session["userCurrent"] = user;
            return View("Index");
        }

        public ActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}