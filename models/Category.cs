using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}