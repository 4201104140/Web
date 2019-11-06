using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tai.DataModels;

namespace Tai.ViewComponents
{
    public class HorizontalMenuViewComponent : ViewComponent
    {
        private readonly MyDbContext _context;
        public HorizontalMenuViewComponent(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _context.Categories.ToList();
            await Task.CompletedTask;
            return View(categories);
        }
    }
}
