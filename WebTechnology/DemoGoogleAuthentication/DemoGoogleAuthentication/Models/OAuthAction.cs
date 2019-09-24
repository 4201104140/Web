using DemoGoogleAuthentication.Libraries.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoGoogleAuthentication.Models
{
    public class OAuthAction
    {
        public User data { get; set; }
        public User GetUser() => data;
        public bool Execute()
        {
            using(var cmd = new LoginRepository())
            {
                cmd.data = this.data;
                return cmd.Execute();
            }
        }
    }
}