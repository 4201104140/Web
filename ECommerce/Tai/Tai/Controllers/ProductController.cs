using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tai.DataModels;
using Tai.Models;
using Tai.Models.ProductModels;

namespace Tai.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;
        public ProductController(MyDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [Route("{category}")]
        public IActionResult Index(string category)
        {
            var products = _dbContext.Products.Where(p=>p.Category.CategoryName.ToUrlFriendly()==category).ToList();
            var productsView = _mapper.Map<List<ProductView>>(products); 
            return View(productsView);
        }
        [Route("chi-tiet/{productName}")]
        public IActionResult Detail(string productName)
        {
            var product = _dbContext.Products.Where(p => p.ProductName.ToUrlFriendly() == productName).SingleOrDefault();
            var productRelates = _dbContext.Products.Where(p => p.CategoryId == product.CategoryId).ToList();
            var productDetail = _mapper.Map<ProductDetail>(product);
            productDetail.ProductRelates = productRelates;
            return View(productDetail);
        }
        [HttpPost]
        public IActionResult Test([FromBody]string search,[FromBody] string name)
        {
            return Ok();
        }
    }
}