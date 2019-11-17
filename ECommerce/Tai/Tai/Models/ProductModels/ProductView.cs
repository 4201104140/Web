using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tai.DataModels;

namespace Tai.Models.ProductModels
{
    public class ProductView : Product
    {
        public double Price => ProductPrice * (1 - SaleOff / 100);
    }
}
