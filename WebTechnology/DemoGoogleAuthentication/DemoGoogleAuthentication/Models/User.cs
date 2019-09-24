using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoGoogleAuthentication.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserImage { get; set; }
        public string UserToken { get; set; }
        public int UserAge { get; set; } = 0;
    }
}