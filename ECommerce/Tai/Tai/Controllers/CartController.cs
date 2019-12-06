using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tai.DataModels;
using Tai.Models;
using Tai.Models.CartModels;
using Tai.Models.ProductModels;

namespace Tai.Controllers
{
    public class CartController : Controller
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;
        public CartController(MyDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("Cart");
                if (data == null)
                    data = new List<CartItem>();
                return data;
            }
        }
        [HttpPost]
        public IActionResult AddToCart([FromBody] CartItem cart)
        {
            List<CartItem> carts = Cart;
            CartItem item = carts.SingleOrDefault(p => p.Product.ProductId == cart.Product.ProductId);
            if (item != null)
            {
                item.Quantity += cart.Quantity;
            }
            else
            {
                Product product = _dbContext.Products.SingleOrDefault(p => p.ProductId == cart.Product.ProductId);
                if (product == null)
                    return RedirectToAction("Error", "Home");
                item = new CartItem
                {
                    Product = _mapper.Map<ProductView>(product),
                    Quantity = cart.Quantity
                };
                carts.Add(item);
            }
            HttpContext.Session.SetObject("Cart", carts);
            
            return RedirectToAction("Index", "Home");
        }
        [Route("/gio-hang/thanh-toan")]
        public IActionResult CheckOut()
        {
            if (HttpContext.Session.GetObject<Customer>("user") == null)
            {
                return RedirectToAction("SignIn", "Login", new { returnUrl = "/gio-hang/thanh-toan" });
            }
            return View();
        }
    }
}