using ProductRepository.Product;
using SaleRepository.SaleItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business
{
    public class SaleItemChangeQty
    {
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public SaleItemChangeQty(int productid, int qty, int saleid)
        {
            using (var cmd = new SaleItemGetQtyByProductIdRepository())
            {
                cmd.ProductId = productid;
                cmd.SaleId = saleid;
                var result = cmd.Execute();
                if (result.Count>0)
                {
                    this.Qty = qty - result[0].Qty;
                }
                else
                {
                    this.Qty = qty;
                }
            }
            using (var cmd = new ProductUpdateQtyRepository())
            {
                cmd.ProductId = productid;
                cmd.Qty = this.Qty;
                cmd.Execute();
            }
        }
    }
}