using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using laptop_shop.Data;
using laptop_shop.models;
using laptop_shop.Interfaces;
using AutoMapper;
using laptop_shop.Dto.Brand;
using LaptopShopSystem.Dto;

namespace laptop_shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {

        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        public BrandController(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        // GET: api/Brand
        [HttpGet]
        public async Task<ActionResult> GetBrands()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var brands = await _brandRepository.GetBrands();

            return Ok(brands);
        }

        // GET: api/Brand/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetBrand([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var brand = await _brandRepository.GetBrandById(id);
            if (brand == null) return NotFound();
            var brandDto = _mapper.Map<BrandDto>(brand);
            return Ok(brandDto);
        }

        // PUT: api/Brand/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateBrand([FromRoute] int id, [FromBody] BrandCreate brand)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var brandModel = _mapper.Map<Brand>(brand);
            var brandUpdated = _brandRepository.UpdateBrand(id, brandModel);
            if (brandUpdated == null) return NotFound();
            return Ok("Update brand success!");
        }

        // POST: api/Brand
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostBrand([FromBody] BrandCreate brand)
        {
            var newBrand = _mapper.Map<Brand>(brand);
            var brandCreated = await _brandRepository.CreateBrand(newBrand);

            return CreatedAtAction("GetBrand", new { id = newBrand.Id }, brandCreated);
        }

        // DELETE: api/Brand/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBrand([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var brand = await _brandRepository.DeleteBrand(id);
            if (brand == null) return NotFound();
            return Ok("Brand was cancel!");
        }
    }
}
