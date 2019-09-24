using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoGoogleAuthentication.Libraries.ConnectDb
{
    public class Connection : IDisposable
    {
        protected string ConnectionString { get; }
        public Connection()
        {
            this.ConnectionString = @"Data Source=.;Initial Catalog=DemoAuthen;Integrated Security=True;Trusted_Connection = yes";
        }

        public void Dispose()
        {
        }
    }
}