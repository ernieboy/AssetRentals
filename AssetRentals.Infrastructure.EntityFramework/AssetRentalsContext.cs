using AssetRentals.Core.DomainModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AssetRentals.Infrastructure.EntityFramework
{
    public  class AssetRentalsContext : DbContext
    {

        public AssetRentalsContext(DbContextOptions<AssetRentalsContext> options) : base(options)
        {
            
        }

        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
