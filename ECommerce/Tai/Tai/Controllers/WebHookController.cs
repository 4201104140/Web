using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Tai.DataModels;

namespace Tai.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebHookController : Controller
    {
        private readonly string VERIFY_TOKEN = "shop_nhom_13";
        private readonly Mykey _key;

        public WebHookController(IOptions<Mykey> key)
        {
            _key = key.Value;
        }
        [HttpGet]
        public IActionResult Index([FromQuery(Name ="hub.mode")] string mode,
            [FromQuery(Name = "hub.challenge")] string challenge,
            [FromQuery(Name = "hub.verify_token")] string verify_token)
        {
            if (mode!=null && verify_token!=null)
            {
                if (mode == "subscribe" && verify_token == VERIFY_TOKEN)
                {
                    return Content(challenge);
                }
                else return StatusCode(403);
            }
            else return StatusCode(403);
        }

        [HttpPost]
        public IActionResult Index()
        {
            var json = (dynamic)null;
            try
            {
                using (StreamReader sr = new StreamReader(this.Request.Body))
                    json = sr.ReadToEnd();
                dynamic data = JsonConvert.DeserializeObject(json);
                postToFb((string)data.entry[0].messaging[0].sender.id, (string)data.entry[0].messaging[0].message.text);
                return Ok(new { data });
            }
            catch(Exception ex)
            {
                return StatusCode(403);
            }
        }

        public void postToFb(string recipientId, string messageText)
        {
            string messageTextAnswer = "Hi";
            string postParameters = string.Format("access_token={0}&recipient={1}&message={2}", _key.Facebook.PageAccessToken, "{ id:" + recipientId + "}", "{ text:\"" + messageTextAnswer + "\"}");
            var client = new HttpClient();
            client.PostAsync("https://graph.facebook.com/v5.0/me/messages", new StringContent(postParameters, Encoding.UTF8, "application/json"));
        }
    }
}