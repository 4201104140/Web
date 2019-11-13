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
                cmd.QueryString = "SELECT * FROM [Category] WHERE [Category].CategoryId = N'" + this.CategoryId+"'";
                return cmd.ExecuteQuery();
            }
        }
    }
}
