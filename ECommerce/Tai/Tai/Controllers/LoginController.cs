using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tai.DataModels;
using Tai.Models;
using Tai.Models.UserModel;

namespace Tai.Controllers
{
    public class LoginController : Controller
    {
        private readonly MyDbContext _context;
        public LoginController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn(string returnUrl= "")
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(SignInModel signIn,string returnUrl = "")
        {
            var user = _context.Customers.Where(c => c.Email == signIn.Email && c.Password == signIn.Password).SingleOrDefault();
            if (user != null)
            {
                HttpContext.Session.SetObject<Customer>("user", user);
            }
            else return RedirectToAction("SignIn","Login",new { returnUrl = returnUrl});
            return Redirect(returnUrl);
        }
    }
}