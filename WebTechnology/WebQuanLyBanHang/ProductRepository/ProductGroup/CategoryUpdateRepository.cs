using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryUpdateRepository : Connection
    {
        public Category Item { get; set; }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "UPDATE [dbo].[Category] SET [CategoryName] = N'" + Item.CategoryName + "' ,[CategoryRemark] = N'" + Item.CategoryRemark+ "', [CategoryParentId] = N'"+ Item.CategoryParentId + "' WHERE [Category].CategoryId = N'" + Item.CategoryId+"'";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
