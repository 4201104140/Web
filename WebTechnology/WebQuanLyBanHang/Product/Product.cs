using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Images { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDetail { get; set; }
        public int ProductQuantity { get; set; }
        public string Barcode { get; set; }
        public double ProductPrice { get; set; }
        public double SaleOff { get; set; }
        public DateTime SaleOffDate { get; set; }
        public string CategoryId { get; set; }

    }
}
