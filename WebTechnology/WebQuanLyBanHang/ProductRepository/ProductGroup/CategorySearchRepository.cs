using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategorySearchRepository : Connection
    {
        public List<dynamic> Exeucte()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "SELECT child.*,dad.CategoryName AS CategoryParentName FROM [Category] AS child left join [Category] AS dad ON child.CategoryParentId = dad.CategoryId";
                return cmd.ExecuteQuery();
            }
        }
    }
}
