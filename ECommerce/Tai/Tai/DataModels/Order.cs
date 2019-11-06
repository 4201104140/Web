using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.DataModels
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [MaxLength(30)]
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [MaxLength(20)]
        public string OrderStatus { get; set; }
        [MaxLength(100)]
        public string OrderEmail { get; set; }
        [MaxLength(100)]
        public string OrderName { get; set; }
        public double PriceTotal { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
