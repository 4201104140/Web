using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.DataModel;
using Shop.Models;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        public readonly MyDbContext _dbContext;
        public readonly IMapper mapper;
        public ProductController(MyDbContext dbContext,IMapper map)
        {
            _dbContext = dbContext;
            mapper = map;
        }
        [Route("{category}")]
        public IActionResult Index(string category)
        {
            var products = _dbContext.Products.Where(p => p.Category.CategoryName.ToUrlFriendly() == category);
            return View(products);
        }
        [Route("chi-tiet/{name}")]
        public IActionResult Detail(string name)
        {
            //HangHoa hh = ctx.HangHoas.SingleOrDefault(p => p.TenHhSeoUrl == name);
            //if (hh != null)
            //{
            //    HangHoaChiTiet hhct = mapper.Map<HangHoaChiTiet>(hh);
            //    return View(hhct);
            //}
            return RedirectToAction("Error", "Home");
        } 
    }
}