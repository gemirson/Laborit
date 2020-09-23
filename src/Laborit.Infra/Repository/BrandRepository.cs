using Laborit.Domain.Brands;
using Laborit.Domain.Interfaces;
using Laborit.Infra.Data;
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
        }
    }
}
