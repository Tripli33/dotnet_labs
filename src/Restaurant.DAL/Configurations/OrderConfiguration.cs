using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.DAL.Entities;
using Restaurant.DAL.EntityGenerators;

namespace Restaurant.DAL.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        var minDate = new DateTime(2024, 2, 15);
        var orders =
            OrderGenerator.GenerateOrders(100, 5, 50,20, minDate);
        
        builder.HasData(orders);
    }
}