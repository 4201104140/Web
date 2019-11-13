using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductInsertRepository : Connection
    {
        string rand()
        {
            var rng = new Random();
            int txt = rng.Next(1000);

            return txt.ToString("000");
        }
        public Product Item { get; set; }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "INSERT INTO [dbo].[Product]([ProductId] ,[ProductName] ,[ProductPrice] ,[Barcode] ,[ProductQuantity],[CategoryId]) VALUES (N'"+Item.CategoryId+rand()+"',N'" + Item.ProductName + "'," + Item.ProductPrice + ",'" + Item.Barcode + "'," + Item.ProductQuantity + ",N'"+Item.CategoryId+"')";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
