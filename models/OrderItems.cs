using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int UnitPrice { get; set; }
        public int Amount { get; set; }
        public int OrderId { get; set; }
    }
}