using Restaurant.BLL.DTOs.Order;

namespace Restaurant.BLL.Contracts;

public interface IOrderService
{
    Task<OrderDto> GetOrderAsync(int id, bool trackChanges);
    Task<OrderForClientDto> GetOrderForClientAsync(int clientId, int orderId, bool trackChanges);
    Task<IEnumerable<OrderDto>> GetOrdersAsync(bool trackChanges);
    Task<IEnumerable<OrderForClientDto>> GetOrdersForClientAsync(int clientId, bool trackChanges);
    Task<OrderForClientDto> CreateOrderForClientAsync(int clientId, OrderForManipulationDto orderForManipulationDto,
        bool trackChanges);
    Task UpdateOrderForClient(int clientId, int orderId, OrderForManipulationDto orderForManipulationDto,
        bool clientTrackChanges, bool orderTrackChanges);
    Task DeleteOrderForClientAsync(int clientId, int orderId, bool trackChanges);
}