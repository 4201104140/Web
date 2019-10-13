using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext ctx;
        private readonly IMapper mapper;
        public HomeController(MyDbContext db, IMapper map)
        {
            ctx = db;
            mapper = map;
        }
        public IActionResult Index()
        {
            var dsHangHoa = ctx.HangHoas.AsQueryable();
            dsHangHoa = dsHangHoa.Where(p => p.MaLoai == 2);
            var hangHoas = mapper.Map<List<HangHoaView>>(dsHangHoa.ToList());
            return View(hangHoas);
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
