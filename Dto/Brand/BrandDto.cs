using laptop_shop.models;

namespace LaptopShopSystem.Dto
{
    public class BrandDto
    {
        public string Name { get; set; }
        public List<Product> products {get; set;}
    }
}
