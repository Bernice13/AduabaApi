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
        [DisplayName(" Category Description"), Display(Name = "Category Description"), DataType(DataType.MultilineText)]]
        public string Description { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual List<Item> Items { get; set; }
    }
}
