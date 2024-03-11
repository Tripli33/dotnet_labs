using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.DAL.Entities;
using Restaurant.DAL.EntityGenerators;

namespace Restaurant.DAL.Configurations;

public class DishConfiguration : IEntityTypeConfiguration<Dish>
{
    public void Configure(EntityTypeBuilder<Dish> builder)
    {
        var dishes = 
            DishGenerator.GenerateDishes(30, 3, 25, 100, 500);
        
        builder.HasData(dishes);
    }
}