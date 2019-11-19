using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.DataModels
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(250)]
        [MinLength(6)]
        public string Password { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        
    }
}
