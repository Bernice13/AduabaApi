using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public Order OrderId { get; set; }
        public User Username { get; set; }
        public Product ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
       
    }
}
