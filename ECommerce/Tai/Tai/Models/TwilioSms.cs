using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Tai.Controllers
{
    public class TwilioSms
    {
        const string accountSid = "AC6101c78f5f5bf252013fe16633a037e4";
        const string authToken = "e0917651a469dfa40d2db1641fba36df";
        public void Send(string Phone)
        {
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                    body: "Cảm ơn quý khách đã tin tưởng và mua hàng tại shop của chúng tôi. Mọi thắc mắc về thông tin sản phẩm quý khách có thể liên hệ vs shop qua mail: phantai9800@gmail.com.",
                    from: new Twilio.Types.PhoneNumber("+16606164005"),
                    to: new Twilio.Types.PhoneNumber(Phone),
                    statusCallback: new Uri("https://shopnhom.azurewebsites.net/")
                );
        }
    }
}