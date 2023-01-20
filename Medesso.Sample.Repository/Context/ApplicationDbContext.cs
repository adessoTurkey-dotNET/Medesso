using Medesso.Sample.Domain.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace Medesso.Sample.Repository.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Product>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
            
        base.OnModelCreating(modelBuilder);
    }
}