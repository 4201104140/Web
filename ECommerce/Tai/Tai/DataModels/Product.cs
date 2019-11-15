using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.DataModels
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [MaxLength(6)]
        public string ProductId { get; set; }
        [Required]
        [MaxLength(250)]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string Images { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDetail { get; set; }
        public string Barcode { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        [Range(0, 100)]
        public double SaleOff { get; set; }
        public DateTime SaleOffDate { get; set; }
        [MaxLength(6)]
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
