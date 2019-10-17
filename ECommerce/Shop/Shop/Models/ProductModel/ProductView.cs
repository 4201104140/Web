using Shop.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.ProductModel
{
    public class ProductView : Product
    {
        public double Price => ProductPrice * (1 - SaleOff / 100);
    }
}
