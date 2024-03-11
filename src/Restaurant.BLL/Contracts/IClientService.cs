using Restaurant.BLL.DTOs.Client;

namespace Restaurant.BLL.Contracts;

public interface IClientService
{
    Task<ClientDto> GetClientAsync(int id, bool trackChanges);
    Task<IEnumerable<ClientDto>> GetClientsAsync(bool trackChanges);
    Task<IEnumerable<ClientDto>> GetClientsAsync(int dishId);
    Task<IEnumerable<ClientWithAvgDishCountDto>> GetClientsWithAvgDishCountAsync();
    Task<ClientDto> CreateClientAsync(ClientForCreationDto clientForCreationDto);
    Task UpdateClientAsync(int id, ClientForUpdateDto clientForUpdate, bool trackChanges);
    Task DeleteClientAsync(int id, bool trackChanges);
}