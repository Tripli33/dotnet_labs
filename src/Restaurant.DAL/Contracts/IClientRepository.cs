using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Contracts;

public interface IClientRepository
{
    Task<Client?> GetClientByIdAsync(int id, bool trackChanges);
    Task<IEnumerable<Client>> GetAllClientsAsync(bool trackChanges);
    Task<IEnumerable<Client>> GetClientsByDishIdAsync(int dishId);
    Task<IEnumerable<(Client client, double avgDishCount)>> GetClientsWithAvgDishCountAsync();
    void CreateClient(Client client);
    void DeleteClient(Client client);
}