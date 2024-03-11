using AutoMapper;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.DTOs.Order;
using Restaurant.BLL.Utilities.CustomExceptions;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Services;

public class OrderService : IOrderService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public OrderService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
    
    public async Task<OrderDto> GetOrderAsync(int id, bool trackChanges)
    {
        var order = await _repositoryManager.OrderRepository.GetOrderByIdAsync(id, trackChanges);

        if (order is null)
        {
            throw new OrderNotFoundException(id);
        }

        var orderDto = _mapper.Map<OrderDto>(order)!;

        return orderDto;
    }

    public async Task<OrderForClientDto> GetOrderForClientAsync(int clientId, int orderId, bool trackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(clientId, trackChanges);

        if (client is null)
        {
            throw new ClientNotFoundException(clientId);
        }

        var orderForClient =
            await _repositoryManager.OrderRepository.GetOrderByIdForClientAsync(clientId, orderId, trackChanges);

        if (orderForClient is null)
        {
            throw new OrderNotFoundException(orderId);
        }

        var orderForClientDto = _mapper.Map<OrderForClientDto>(orderForClient)!;

        return orderForClientDto;
    }

    public async Task<IEnumerable<OrderDto>> GetOrdersAsync(bool trackChanges)
    {
        var orders = await _repositoryManager.OrderRepository.GetAllOrdersAsync(trackChanges);
        var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders)!;

        return ordersDto;
    }

    public async Task<IEnumerable<OrderForClientDto>> GetOrdersForClientAsync(int clientId, bool trackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(clientId, trackChanges);

        if (client is null)
        {
            throw new ClientNotFoundException(clientId);
        }

        var ordersForClient = 
            await _repositoryManager.OrderRepository.GetAllOrdersForClientAsync(clientId, trackChanges);
        var ordersForClientDto = _mapper.Map<IEnumerable<OrderForClientDto>>(ordersForClient)!;

        return ordersForClientDto;
    }

    public async Task<OrderForClientDto> CreateOrderForClientAsync(int clientId, 
        OrderForManipulationDto orderForManipulationDto, bool trackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(clientId, trackChanges);
        
        if (client is null)
        {
            throw new ClientNotFoundException(clientId);
        }

        var order = _mapper.Map<Order>(orderForManipulationDto)!;
        
        _repositoryManager.OrderRepository.CreateOrderForClient(clientId, order);
        await _repositoryManager.SaveAsync();

        var orderForClientDto = _mapper.Map<OrderForClientDto>(order)!;
        
        return orderForClientDto;
    }

    public async Task UpdateOrderForClient(int clientId, int orderId, OrderForManipulationDto orderForManipulationDto,
        bool clientTrackChanges, bool orderTrackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(clientId, clientTrackChanges);

        if (client is null)
        {
            throw new ClientNotFoundException(clientId);
        }

        var order = await _repositoryManager.OrderRepository.GetOrderByIdAsync(orderId, orderTrackChanges);

        if (order is null)
        {
            throw new OrderNotFoundException(orderId);
        }

        _mapper.Map(orderForManipulationDto, order);
        await _repositoryManager.SaveAsync();
    }

    public async Task DeleteOrderForClientAsync(int clientId, int orderId, bool trackChanges)
    {
        var client = await _repositoryManager.ClientRepository.GetClientByIdAsync(clientId, trackChanges);

        if (client is null)
        {
            throw new ClientNotFoundException(clientId);
        }

        var orderForClient =
            await _repositoryManager.OrderRepository.GetOrderByIdForClientAsync(clientId, orderId, trackChanges);

        if (orderForClient is null)
        {
            throw new OrderNotFoundException(orderId);
        }
        
        _repositoryManager.OrderRepository.DeleteOrder(orderForClient);
        await _repositoryManager.SaveAsync();
    }
}