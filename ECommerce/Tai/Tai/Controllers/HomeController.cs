using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tai.Models;
using Tai.Models.CartModels;

namespace Tai.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var aa = HttpContext.Session.GetObject<List<CartItem>>("Cart");
            if (aa == null)
            {
                List<CartItem> cartItem = new List<CartItem>();
                HttpContext.Session.SetObject("Cart", cartItem);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
