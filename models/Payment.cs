using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime PayTime { get; set; }
        public string Status { get; set; }
        public Order Order { get; set; }
        public User User { get; set; }
    }
}