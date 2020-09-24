using Laborit.Domain.Brands;
using System;
using System.Threading.Tasks;

namespace Laborit.Domain.Interfaces
{
    public interface IBrandRepository
    {
        Task AddAsync(Brand brand);
        Task<Brand> GetBrandAsync(Guid Id);
        Task RemoveAsync(Brand brand);
    }
}
