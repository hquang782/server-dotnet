using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class CartItems
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}