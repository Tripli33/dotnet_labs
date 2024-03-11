using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Contracts;

public interface IOrderRepository
{
    Task<Order?> GetOrderByIdAsync(int id, bool trackChanges);
    Task<Order?> GetOrderByIdForClientAsync(int clientId, int orderId, bool trackChanges);
    Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges);
    Task<IEnumerable<Order>> GetAllOrdersForClientAsync(int clientId, bool trackChanges);
    void CreateOrderForClient(int clientId, Order order);
    void DeleteOrder(Order order);
}