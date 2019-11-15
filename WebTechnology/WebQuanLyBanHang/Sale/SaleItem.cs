using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SaleItem
    {
        public string SaleItemId { get; set; }
        public string SaleId { get; set; }
        public string ProductId { get; set; }
        public double ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
    }
}
