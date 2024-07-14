using Microsoft.EntityFrameworkCore;
using MotoApp.DataAccsess.Data.Entities;

public class MotoAppDbContext : DbContext
{
    public MotoAppDbContext(DbContextOptions<MotoAppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.LogTo(Console.WriteLine);
}