using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tai.DataModels;

namespace Tai.Models.HomeModels
{
    public class IndexModel
    {
        public List<Product> ProductSales { get; set; }
        public List<Category> GetCategories { get; set; }
        public List<Product> ProductTopSells { get; set; }
    }
}
