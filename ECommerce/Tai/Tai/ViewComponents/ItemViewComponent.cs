using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Tai.DataModels;
using Tai.Models.ProductModels;

namespace Tai.ViewComponents
{
    public class ItemViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Product product)
        {
            await Task.CompletedTask;
            return View(product);
        }
    }
}
