using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.Other
{
    public class Address
    {
        public string HouseNumber { get; set; }
        [Required(ErrorMessage = "Street name is required")]
        [StringLength(50)]
        public string StreetName { get; set; }
        [Required(ErrorMessage = "City is required")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [DisplayName("PostalCode")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Country is reqiuired")]
        [StringLength(40)]
        public string Country { get; set; }
    }
}
