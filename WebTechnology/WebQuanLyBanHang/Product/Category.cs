using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryRemark { get; set; }
        public string CategoryIcon { get; set; }
        public string CategoryParentId { get; set; }
    }
}
