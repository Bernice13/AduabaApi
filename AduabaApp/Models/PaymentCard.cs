using AduabaApp.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class PaymentCard
    { [Key]
        public User UserId { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("FirstName"), StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("LastName"), StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Address field cannot be empty")]
        public Address BillingAddress { get; set; }
        [Required]
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        [Required]
        public DateTime CardExpiry{ get; set; }
       
    }
}
