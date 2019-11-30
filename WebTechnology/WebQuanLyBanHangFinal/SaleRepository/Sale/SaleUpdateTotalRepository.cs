using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleUpdateTotalRepository:Connection
    {
        public SaleItem Item { get; set; }
        public bool Excute()
        {
            using(var cmd=new Query())
            {
                cmd.QueryString = "Update Sale Set Total  = (select sum(SaleItem.Qty*SaleItem.Price) from SaleItem Where SaleItem.SaleId=" + Item.SaleId+") Where SaleId=" + Item.SaleId;
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
