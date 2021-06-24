using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }
        [Required, StringLength(50), Display(Name = "Name")]
        public string CategoryName { get; set; }
        [DisplayName(" Product Description"), Display(Name = "Product Description"), DataType(DataType.MultilineText)]]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
