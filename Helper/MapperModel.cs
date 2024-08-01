using AutoMapper;
using laptop_shop.Dto.Brand;
using laptop_shop.models;
using LaptopShopSystem.Dto;


namespace laptop_shop.Helper
{
    public class MapperModel : Profile
    {
        public MapperModel()
        {
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Brand, BrandCreate>().ReverseMap();
        }
    }
}