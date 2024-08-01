using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string AddressDetails { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Wishlist> Wishlists { get; set; }
    }
}