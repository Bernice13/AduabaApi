using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class Item
    {
        [Key]
        public string ItemId { get; set; }
        public Product Product { get; set; }
        public Product ProductId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public decimal ItemAmount { get; set; }
        [Required]
        public string ItemQuantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
