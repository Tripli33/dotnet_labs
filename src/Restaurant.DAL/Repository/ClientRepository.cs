using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Repository;

public class ClientRepository : RepositoryBase<Client>, IClientRepository
{
    public ClientRepository(ApplicationContext context) : base(context)
    {
    }

    public async Task<Client?> GetClientByIdAsync(int id, bool trackChanges) => 
        await FindByCondition(c => c.ClientId == id, trackChanges)
            .SingleOrDefaultAsync();

    public async Task<Client?> GetClientByEmailAsync(string email, bool trackChanges) =>
        await FindByCondition(c => c.Email != null && c.Email.Equals(email), trackChanges)
            .FirstOrDefaultAsync();

    public async Task<IEnumerable<Client>> GetAllClientsAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

    public async Task<IEnumerable<Client>> GetClientsByDishIdAsync(int dishId) =>
        await Context.Clients
            .Include(c => c.Orders)
            .Where(c => c.Orders != null && c.Orders.Any(o => o.DishId == dishId))
            .OrderBy(c => c.Name)
            .ToListAsync();
    
    public async Task<IEnumerable<(Client client, double avgDishCount)>> GetClientsWithAvgDishCountAsync()
    {
        var clientsWithOrders = await Context.Clients
            .Include(c => c.Orders)
            .OrderBy(c => c.Name)
            .ToListAsync();

        return clientsWithOrders
            .Select(c => (
                client: c, avgDishCount: c.Orders is not null && c.Orders.Any() 
                    ? c.Orders.Average(o => o.Quantity) 
                    : 0)
            );
    }
    
    public void CreateClient(Client client) => Create(client);

    public void DeleteClient(Client client) => Delete(client);
}