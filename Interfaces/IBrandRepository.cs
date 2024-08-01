using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using laptop_shop.models;

namespace laptop_shop.Interfaces
{
    public interface IBrandRepository
    {
        Task<Brand> CreateBrand(Brand brand);
        Task<Brand?> UpdateBrand(int id, Brand brand);
        Task<Brand?> DeleteBrand(int id);
        Task<Brand?> GetBrandById(int id);
        Task<bool> BrandExists(int id);
        Task<List<Brand>> GetBrands();
    }
}