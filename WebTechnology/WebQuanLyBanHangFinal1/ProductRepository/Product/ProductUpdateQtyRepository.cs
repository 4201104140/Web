using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepository.Product
{
    public class ProductUpdateQtyRepository:Connection
    {
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public bool Execute()
        {
            using(var cmd= new Query())
            {
                cmd.QueryString = "update Product set Qty=(select Qty from Product where ProductId="+ProductId+")- "+Qty+" where ProductId="+ProductId;
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
