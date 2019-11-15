using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDataBase;
namespace Repository
{
    public class SaleItemGetByIdRepository : Connection
    {
        public string SaleId { get; set; }
        public List<dynamic> Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "SELECT [SaleItem].*,[Product].ProductName,([Product].ProductQuantity * [Product].ProductPrice) as Total FROM [SaleItem] LEFT JOIN [Product] on [Product].ProductId = [SaleItem].ProductId WHERE [SaleItem].SaleId = N'" + SaleId+"'";
                return cmd.ExecuteQuery();
            }
        }
    }
}
