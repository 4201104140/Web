using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryInsertRepository : Connection
    {
        public Category Item { get; set; }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "INSERT INTO [dbo].[Category]([CategoryId] ,[ProductId] ,[CategoryName] ,[Remark]) VALUES ((SELECT isnull(MAX(CategoryId),0) + 1 from [Category])," + 1 + ",N'" + Item.CategoryName + "','" + Item.CategoryRemark + "')";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
