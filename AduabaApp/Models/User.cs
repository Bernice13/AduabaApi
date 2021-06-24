using AduabaApp.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
       [Required(ErrorMessage = "Username is required")]
       [DisplayName("Username")]
       [MaxLength(10)]

        public string Username { get; set; }
        [Required(ErrorMessage ="First Name is required")]
        [DisplayName( "FirstName"), StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName( "LastName"), StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email"), StringLength(50)]
        [RegularExpression(@"[A-Za-z0-9. %+-] +@ [A-Za-z0-9. -] +\.[A-Za-z]{2,4}", ErrorMessage = "Email is not valid. ")]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        [DisplayName("Email"), StringLength(11)]

        public string PhoneNumber{ get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password"), StringLength(10)]
        public string Password{ get; set; }
        [Required(ErrorMessage = "Address is required")]
        [DisplayName("Address"), StringLength(100)]
        public Address Address{ get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
        public ICollection<PaymentCard> PaymentCards { get; set; }
        public ICollection<Item> ShoppingCart { get; set; }
        public ICollection<Order> CustomerOrders { get; set; }

    }
}
