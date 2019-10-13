using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Helper;
using Shop.Models;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly MyDbContext ctx;
        private readonly IMapper mapper;
        public CartController(MyDbContext db, IMapper map)
        {
            ctx = db;
            mapper = map;
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
            CartItem item = carts.SingleOrDefault(p => p.HangHoa.MaHh == cart.HangHoa.MaHh);
            if (item != null)
            {
                item.SoLuong += cart.SoLuong;
            }
            else
            {
                HangHoa hh = ctx.HangHoas.SingleOrDefault(p => p.MaHh == cart.HangHoa.MaHh);
                if (hh == null)
                    return RedirectToAction("Error", "Home");
                item = new CartItem
                {
                    HangHoa = mapper.Map<HangHoaView>(hh),
                    SoLuong = cart.SoLuong
                };
                carts.Add(item);
            }
            HttpContext.Session.SetObject("Cart", carts);
            //List<CartItem> aa = HttpContext.Session.GetObject<List<CartItem>>("Cart");
            return RedirectToAction("Index","Home");
        }
    }
}