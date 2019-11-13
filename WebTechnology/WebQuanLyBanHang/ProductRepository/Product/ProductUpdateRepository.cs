using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductUpdateRepository : Connection
    {
        public Product Item { get; set; }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "UPDATE [dbo].[Product] SET [ProductName] = N'" + Item.ProductName + "' ,[ProductPrice] = " + Item.ProductPrice + " ,[Barcode] = '" + Item.Barcode + "' ,[ProductQuantity] = " + Item.ProductQuantity + ",[CategoryId] = N'" + Item.CategoryId+"' WHERE [Product].ProductId = N'" + Item.ProductId+"'";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
