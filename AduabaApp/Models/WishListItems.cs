using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class WishListItems
    {[Key]
        public int WishListId { get; set; }
        public virtual Item Item { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
