using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleRepository.SaleItem
{
   

    public class SaleItemGetQtyByProductIdRepository:Connection
    {
        public int ProductId { get; set; }
        public int SaleId { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "select Qty from SaleItem where SaleId="+SaleId+" and ProductId="+ProductId;
                return cmd.ExecuteQuery();
            }
        }
    }
}
