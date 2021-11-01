using System;
using System.Collections.Generic;

#nullable disable

namespace CoffeeShop2EFCORELab
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HomeStore { get; set; }
        public bool? SeniorDiscount { get; set; }
    }
}
