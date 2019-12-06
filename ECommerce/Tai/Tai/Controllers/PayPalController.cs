using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using BraintreeHttp;
using Tai.Models.CartModels;
using Tai.Models;

using PayPalCheckoutSdk.Orders;
using Tai.Models.CaptureIntent;

namespace Tai.Controllers
{
    [Route("thanh-toan")]
    public class PayPalController : Controller
    {
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
        [Route("paypal")]
        public IActionResult CheckOut(string Address, string Phone)
        {
            var host = HttpContext.Request.Scheme +"://"+ HttpContext.Request.Host;
            HttpContext.Session.SetObject<string>("phone", Phone);
            if (Cart.Count == 0) return View("Fail");
            var createOrderResponse = CreateOrderPayPal.CreateOrder(Cart,Address,host).Result;
            var createOrderResult = createOrderResponse.Result<Order>();

            foreach (PayPalCheckoutSdk.Orders.LinkDescription link in createOrderResult.Links)
            {
                if(link.Rel== "approve")
                {
                    var aa = link.Href;
                    return Redirect(aa);
                }
            }
           
            return RedirectToAction("Error","Home");
        }
        [Route("thanh-toan-thanh-cong")]
        public IActionResult Success(string token,string PayerID)
        {
            //AmountWithBreakdown amount = createOrderResult.PurchaseUnits[0].AmountWithBreakdown;
            var authorizeOrderResponse = AuthorizeOrderPayPal.AuthorizeOrder(token).Result;
            var authorizeOrderResult = authorizeOrderResponse.Result<Order>();
            var authorizationId = authorizeOrderResult.PurchaseUnits[0].Payments.Authorizations[0].Id;
            AmountWithBreakdown authorixedAmount = authorizeOrderResult.PurchaseUnits[0].AmountWithBreakdown;
            var captureOrderResponse = CaptureOrderPayPal.CaptureOrder(authorizationId).Result;
            //captureOrderResult = captureOrderResponse.Result<Capture>();
            var sendSms = new TwilioSms();
            sendSms.Send(HttpContext.Session.GetObject<string>("phone"));
            HttpContext.Session.Remove("Cart");
            return View();
        }
        [Route("thanh-toan-that-bai")]
        public IActionResult Fail()
        {
            return View();
        }
    }    
}