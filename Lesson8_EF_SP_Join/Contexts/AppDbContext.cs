using Lesson8_EF_SP_Join.Models;
using Lesson8_EF_SP_Join.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Lesson8_EF_SP_Join.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configRoot = new ConfigurationBuilder()
                    .AddJsonFile($"appsettings.json", true, true)
                    .Build();

        var connectionString = configRoot.GetConnectionString("SqlServer");

        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);

        base.OnModelCreating(modelBuilder);
    }


    public override int SaveChanges()
    {
        foreach (var item in ChangeTracker.Entries())
        {
            if (item.Entity is BaseEntity entity)
            {
                if (item.State == EntityState.Added)
                    entity.CreatedDate = DateTime.Now;

                if (item.State == EntityState.Modified)
                    entity.ModifierDate = DateTime.Now;

            }
        }
        return base.SaveChanges();
    }


    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Category> Categories { get; set; }



}
