using Laborit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laborit.Infra.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IBrandRepository Brands { get; }
        IModelRepository Models { get; }
        IVehicleRepository Vehicles { get; }
        Task SaveAsync();
    }
}
