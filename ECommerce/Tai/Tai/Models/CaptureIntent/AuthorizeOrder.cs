using BraintreeHttp;
using PayPalCheckoutSdk.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.Models.CaptureIntent
{
    public class AuthorizeOrder
    {
        public async static Task<HttpResponse> AuthorizeOrders(string OrderId)
        {
            var request = new OrdersAuthorizeRequest(OrderId);
            request.Prefer("return=representation");
            request.RequestBody(new AuthorizeRequest());
            var response = await PayPalClient.client().Execute(request);

            return response;
        }
    }
}
