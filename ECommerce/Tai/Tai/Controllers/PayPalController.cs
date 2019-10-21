using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using BraintreeHttp;
using Tai.Models.CartModels;
using Tai.Models;
using Tai.Models.CaptureIntent;
using PayPalCheckoutSdk.Orders;

namespace Tai.Controllers
{
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
        
        public async Task<IActionResult> CheckOut()
        {
            var createOrderResponse = await CreateOrder.CreateOrders(Cart);
            var createOrderResult = createOrderResponse.Result<Order>();
            foreach (LinkDescription link in createOrderResult.Links)
            {
                if(link.Rel== "approve")
                {
                    AmountWithBreakdown amount = createOrderResult.PurchaseUnits[0].AmountWithBreakdown;
                    return Redirect(link.Href);
                }
            }
            return RedirectToAction("Error", "Home");
        }
        public IActionResult Access(string token,string PayerID)
        {
            var authorizeOrderResponse = AuthorizeOrder.AuthorizeOrders(token).Result;
            var authorizeOrderResult = authorizeOrderResponse.Result<Order>();
            var ii = authorizeOrderResult.Status;
            var authorizationId = authorizeOrderResult.PurchaseUnits[0].Payments.Authorizations[0].Id;
            return View();
        }
    }
}