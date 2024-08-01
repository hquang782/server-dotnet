using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status {get; set;}
        public List<Product>? Products { get; set; }
    }
}