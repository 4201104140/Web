using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryDeleteByIdRepository : Connection
    {
        public int CategoryId { get; set; }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "DELETE FROM [Category] WHERE [Category].CategoryId = " + this.CategoryId;
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
