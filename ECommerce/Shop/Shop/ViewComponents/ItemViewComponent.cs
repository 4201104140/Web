using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class ItemViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(HangHoaView hangHoa)
        {
            await Task.Delay(1);
            return View(hangHoa);
        }
    }
}
