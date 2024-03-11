using AutoMapper;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.DTOs.Client;
using Restaurant.BLL.Utilities.CustomExceptions;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Services;

public class ClientService : IClientService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public ClientService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
    
    public async Task<ClientDto> GetClientAsync(int id, bool trackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(id, trackChanges);

        if (client is null)
        {
            throw new ClientNotFoundException(id);
        }
        
        var clientDto = _mapper.Map<ClientDto>(client)!;

        return clientDto;
    }

    public async Task<IEnumerable<ClientDto>> GetClientsAsync(bool trackChanges)
    {
        var clients = await _repositoryManager.ClientRepository.GetAllClientsAsync(trackChanges);
        var clientsDto = _mapper.Map<IEnumerable<ClientDto>>(clients)!;

        return clientsDto;
    }

    public async Task<IEnumerable<ClientDto>> GetClientsAsync(int dishId)
    {
        var clients = await _repositoryManager.ClientRepository.GetClientsByDishIdAsync(dishId);
        var clientsDto = _mapper.Map<IEnumerable<ClientDto>>(clients)!;

        return clientsDto;
    }

    public async Task<IEnumerable<ClientWithAvgDishCountDto>> GetClientsWithAvgDishCountAsync()
    {
        var clientsWithAvgDishCount = await 
            _repositoryManager.ClientRepository.GetClientsWithAvgDishCountAsync();
        var clientsDto =
            clientsWithAvgDishCount.Select(e => new ClientWithAvgDishCountDto(
                _mapper.Map<ClientDto>(e.client), Math.Round(e.avgDishCount, 2))
            );
        
        return clientsDto;
    }

    public async Task<ClientDto> CreateClientAsync(ClientForCreationDto clientForCreationDto)
    { 
        var client = _mapper.Map<Client>(clientForCreationDto)!;
        
        _repositoryManager.ClientRepository.CreateClient(client);
        await _repositoryManager.SaveAsync();

        var clientDto = _mapper.Map<ClientDto>(client)!;

        return clientDto;
    }

    public async Task UpdateClientAsync(int id, ClientForUpdateDto clientForUpdate, bool trackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(id, trackChanges);

        if (client is null)
        {
            throw new ClientNotFoundException(id);
        }

        _mapper.Map(clientForUpdate, client);
        await _repositoryManager.SaveAsync();
    }

    public async Task DeleteClientAsync(int id, bool trackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(id, trackChanges);

        if (client is null)
        {
            throw new ClientNotFoundException(id);
        }
        
        _repositoryManager.ClientRepository.DeleteClient(client);
        await _repositoryManager.SaveAsync();
    }
}