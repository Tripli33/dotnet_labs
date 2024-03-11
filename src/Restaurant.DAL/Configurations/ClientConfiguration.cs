using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.DAL.Entities;
using Restaurant.DAL.EntityGenerators;

namespace Restaurant.DAL.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        var clients = 
            ClientGenerator.GenerateClients(50, 25, 99, 5, 50);
        
        builder.HasData(clients);
    }
}