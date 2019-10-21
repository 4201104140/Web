using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tai.Models.ProductModels;

namespace Tai.Models.CartModels
{
    public class CartItem
    {
        public ProductView Product { get; set; }
        public int Quantity { get; set; }
        public double Price => Quantity * Product.Price;
        
    }
    
}
