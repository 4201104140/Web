using BraintreeHttp;
using PayPalCheckoutSdk.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.Models.CaptureIntent
{
    public class AuthorizeOrderPayPal
    {
        public async static Task<HttpResponse> AuthorizeOrder(string OrderId)
        {
            var request = new OrdersAuthorizeRequest(OrderId);
            request.Prefer("return=representation");
            request.RequestBody(new AuthorizeRequest());
            var response = await PayPalClient.client().Execute(request);
            return response;
        }
    }
}
