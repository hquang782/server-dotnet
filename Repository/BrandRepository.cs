using laptop_shop.Data;
using laptop_shop.Interfaces;
using laptop_shop.models;
using Microsoft.EntityFrameworkCore;

namespace laptop_shop.Repository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly DataContext _context;

        public BrandRepository(DataContext context)
        {
            _context = context;
        }

        public Task<bool> BrandExists(int id)
        {
            return _context.Brands.AnyAsync(b => b.Id == id);
        }

        public async Task<Brand> CreateBrand(Brand brand)
        {
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
            return brand;
        }

        // change to status inactive
        public async Task<Brand?> DeleteBrand(int id)
        {
            var brand = await _context.Brands.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null) return null;
            brand.Status = "Inactive";
            await _context.SaveChangesAsync();
            return brand;
        }

        public async Task<Brand?> GetBrandById(int id)
        {
            return await _context.Brands.Include(b => b.Products).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _context.Brands.Where(b => b.Status == "Active").ToListAsync();
        }

        public async Task<Brand?> UpdateBrand(int id, Brand brand)
        {
            var existingBrand = await _context.Brands.FindAsync(id);
            if (existingBrand == null) return null;

            existingBrand.Name = brand.Name;
            existingBrand.Status = brand.Status;

            await _context.SaveChangesAsync();
            return existingBrand;
        }
    }
}