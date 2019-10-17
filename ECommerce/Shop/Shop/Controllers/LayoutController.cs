using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.DataModel;

namespace Shop.Controllers
{
    public class LayoutController : Controller
    {
        private readonly MyDbContext _context;
        public LayoutController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult HorizontalMenu()
        {
            return PartialView("_HorizontalMenu",_context.Categories.ToList());
        }
    }
}