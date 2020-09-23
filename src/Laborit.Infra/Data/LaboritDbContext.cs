using Laborit.Domain.Brands;
using Laborit.Domain.Models;
using Laborit.Domain.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace Laborit.Infra.Data
{
    public class LaboritDbContext: DbContext
    {
        public LaboritDbContext(DbContextOptions<LaboritDbContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ModelsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VehiclesEntityTypeConfiguration());
        }
    }
}
