using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.Models.ProductModels
{
    public class ProductDetail : ProductView
    {
        public bool CheckInStock => ProductQuantity > 0;
        public string Status
        {
            get
            {
                if (!CheckInStock) return "Hết hàng";
                if (ProductQuantity > 4) return "Còn hàng";
                return "Sắp hết";
            }
        }
    }
}
