using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tai.DataModels;
using Tai.Models;
using Tai.Models.CartModels;
using Tai.Models.HomeModels;

namespace Tai.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _context;
        public HomeController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productSales = _context.Products.Where(p => p.SaleOff > 0 && p.SaleOffDate > DateTime.Now).OrderByDescending(p => p.SaleOff).Take(8).ToList();
            var categories = _context.Categories.Where(c => c.CategoryParentId != null).ToList();

            var model = new IndexModel
            {
                ProductSales = productSales,
                GetCategories = categories,
                ProductTopSells = productSales
            };
            return View(model);
        }
        [Route("trang-chu/{category}")]
        public IActionResult Index(string category)
        {
            var productSales = _context.Products.Where(p => p.SaleOff > 0 && p.SaleOffDate > DateTime.Now).OrderByDescending(p => p.SaleOff).Take(8).ToList();
            var categories = _context.Categories.Where(c => c.CategoryParentId != null).ToList();
            var productTopSell = new List<Product>();
            if (category != null)
            {
                productTopSell = _context.Products.Where(p => p.Category.CategoryName.ToUrlFriendly() == category).OrderByDescending(p => p.SaleOff).Take(8).ToList();
            }
            else
            {
                productTopSell = productSales;
            }
            
            var model = new IndexModel
            {
                ProductSales = productSales,
                GetCategories = categories,
                ProductTopSells = productTopSell
            };
            return View(model);
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
