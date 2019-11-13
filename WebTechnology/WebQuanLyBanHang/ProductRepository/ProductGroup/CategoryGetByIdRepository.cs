using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryGetByIdRepository : Connection
    {
        public string CategoryId { get; set; }
        public List<dynamic> Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "SELECT child.*, dad.CategoryName as CategoryParentName FROM [Category] AS child LEFT JOIN [Category] AS dad ON child.CategoryParentId = dad.CategoryId WHERE [child].CategoryId = N'" + this.CategoryId+"'";
                return cmd.ExecuteQuery();
            }
        }
    }
}
