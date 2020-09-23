using Laborit.Domain.Interfaces;
using Laborit.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laborit.Infra.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBrandRepository Brands => throw new NotImplementedException();

        public IModelRepository Models => throw new NotImplementedException();

        public IVehicleRepository Vehicles  => throw new  NotImplementedException();

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
