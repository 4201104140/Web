using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDataBase
{
    public abstract class Connection : IDisposable
    {
        protected string ConnectionString { get; }
        protected string ConnectionString2 { get; }
        public Connection()
        {
            this.ConnectionString = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
            this.ConnectionString2 = @"Server=tcp:shopnhom.database.windows.net,1433;Initial Catalog=Shop;Persist Security Info=False;User ID=tantai;Password=Tai9800@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        public void Dispose()
        {
        }
    }
}
