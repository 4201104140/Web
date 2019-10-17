using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.DataModel
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [MaxLength(68)]
        public string ProductId { get; set; }
        [Required]
        [MaxLength(250)]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string Images { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        [Range(0,100)]
        public double SaleOff { get; set; }
        [MaxLength(68)]
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
