using Microsoft.EntityFrameworkCore;
using MotoApp.Data.Entities;

namespace MotoApp.Data
{
    public class MotoAppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<BisinessPantners> businessPartners => Set<BisinessPantners>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
