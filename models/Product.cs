using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laptop_shop.models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrls { get; set; }
        public int BrandId { get; set; }
        public string? Color { get; set; }
        public int Discount { get; set; }
        public int Price { get; set; }
        public double Rate { get; set; }
        public int Remain { get; set; }
        public int Total { get; set; }
        public string? Type { get; set; }

        public required ProductDetails Details { get; set; }
        public DateTime Created { get; set; }
        public required List<ProductCategory> ProductCategories { get; set; }
        public List<Wishlist> Wishlists { get; set; }
        public Brand? Brand { get; set; }
    }
}