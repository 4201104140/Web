using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.DataModels
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public string DetailId { get; set; }
        [MaxLength(100)]
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductTax { get; set; }
        [MaxLength(30)]
        public string OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
