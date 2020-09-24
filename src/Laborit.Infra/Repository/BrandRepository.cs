using Laborit.Domain.Brands;
using Laborit.Domain.Interfaces;
using Laborit.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Laborit.Infra.Repository
{
    public class BrandRepository:IBrandRepository
    {

        private readonly LaboritDbContext _context;

        public BrandRepository(LaboritDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Brand brand)
        {
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
        }

        public async Task<Brand> GetBrandAsync(Guid Id)
        {
            return await _context.Brands.FirstOrDefaultAsync(x=>x.Id ==Id);
        }

        public async  Task RemoveAsync(Brand brand)
        {
            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();
        }
    }
}
