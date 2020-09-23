using Laborit.Domain.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Laborit.Infra.Data
{
    internal class VehiclesEntityTypeConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}