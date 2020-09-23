using Laborit.Domain.Brands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laborit.Domain.Interfaces
{
    public interface IBrandRepository
    {
        Task AddAsync(Brand brand);
    }
}
