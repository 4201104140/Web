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
        [MaxLength(6)]
        public string CategoryId { get; set; }
        [Required]
        [MaxLength(250)]
        public string CategoryName { get; set; }
        [MaxLength(250)]
        public string CategoryRemark { get; set; }
        [MaxLength(20)]
        public string CategoryIcon { get; set; }

        [MaxLength(6)]
        public string CategoryParentId { get; set; }
        [ForeignKey("CategoryParentId")]
        public Category CategoryParent { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
