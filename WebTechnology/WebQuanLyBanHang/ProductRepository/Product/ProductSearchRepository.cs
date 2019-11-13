using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductSearchRepository : Connection
    {
        public List<dynamic> Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "SELECT [Product].*,[Category].CategoryName FROM [Product] LEFT JOIN [Category] on [Category].CategoryId = [Product].CategoryId";
                return cmd.ExecuteQuery();
            }
        }
    }
}
