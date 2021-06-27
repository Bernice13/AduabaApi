using AduabaApp.Other;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class ApplicationUser:IdentityUser
    {
     
        [Required(ErrorMessage ="First Name is required")]
        [DisplayName( "FirstName"), StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName( "LastName"), StringLength(50)]
        public string LastName { get; set; }

        
        [Required(ErrorMessage = "Address is required")]
        [DisplayName("Address"), StringLength(100)]
        public string Address{ get; set; }
      
        public List<PaymentCard> PaymentCards { get; set; }
       
        public List<Order> CustomerOrders { get; set; }

    }
}
