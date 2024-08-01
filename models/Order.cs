using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductPrice { get; set; }

        public int ShipFee { get; set; }
        public int Total { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ExpireTime { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        public string PayMethod { get; set; }
        public User User { get; set; }
        public string Status { get; set; }
        public int? VoucherId { get; set; }
        public Voucher? Voucher { get; set; }
    }
}