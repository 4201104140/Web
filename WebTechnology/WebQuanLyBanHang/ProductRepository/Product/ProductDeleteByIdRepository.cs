using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductDeleteByIdRepository : Connection
    {
        public string ProductId { get; set; }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "DELETE FROM [Product] WHERE [Product].ProductId = N'" + this.ProductId+"'";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
