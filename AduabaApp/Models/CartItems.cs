using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class CartItems
    {[Key]
        public string CartId { get; set; }
        public Item Item { get; set; }
        public ICollection<Item> Items { get; set; }
        public virtual Product Product{ get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
