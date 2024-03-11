using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restaurant.DAL.Configurations;
using Restaurant.DAL.Entities;

namespace Restaurant.DAL;

public class ApplicationContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Client> Clients { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Order> Orders { get; set; }

    public ApplicationContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("db_connection");
        
        optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36)));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .Property(o => o.OrderDate)
            .HasColumnType("datetime");
        modelBuilder.Entity<Order>()
            .Property(o => o.PaymentType)
            .HasConversion(
                pt => pt.ToString(),
                pt => (PaymentType)Enum.Parse(typeof(PaymentType), pt)
            );
        modelBuilder.ApplyConfiguration(new DishConfiguration());
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
    }
}