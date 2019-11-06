using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.DataModels
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [MaxLength(68)]
        public string CategoryId { get; set; }
        [Required]
        [MaxLength(250)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        [MaxLength(20)]
        public string CategoryIcon { get; set; }

        [MaxLength(68)]
        public string CategoryParentId { get; set; }
        [ForeignKey("CategoryParentId")]
        public Category CategoryParent { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
