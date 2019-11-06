using BraintreeHttp;
using PayPalCheckoutSdk.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.Models.CaptureIntent
{
    public class CaptureOrderPayPal
    {
        public async static Task<HttpResponse> CaptureOrder(string AuthorizationId)
        {
            var request = new AuthorizationsCaptureRequest(AuthorizationId);
            request.Prefer("return=representation");
            request.RequestBody(new CaptureRequest());
            var response = await PayPalClient.client().Execute(request);
            return response;
        }
    }
}
