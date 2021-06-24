using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class Product
    {[Key]
        public string ProductId { get; set; }
        public Category CategoryId { get; set; }
        public Category Category { get; set; }
        [Required, Display(Name = "Product Name"), StringLength(100)]
        public string ProductName { get; set; }
        [Required, StringLength(1000)]
        [Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string ProuductDescription { get; set; }
       
        public string ImagePath { get; set; }

        [Required, Display(Name = "Price")]
        public decimal UnitPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
