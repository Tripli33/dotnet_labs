using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Repository;

public class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(ApplicationContext context) : base(context)
    {
    }
    
    public async Task<Order?> GetOrderByIdAsync(int id, bool trackChanges) =>
        await FindByCondition(o => o.OrderId == id, trackChanges)
            .SingleOrDefaultAsync();

    public async Task<Order?> GetOrderByIdForClientAsync(int clientId, int orderId, bool trackChanges) =>
        await FindByCondition(o => o.ClientId == clientId && o.OrderId == orderId, trackChanges)
            .SingleOrDefaultAsync();
    
    public async Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(o => o.OrderDate)
            .ThenBy(o => o.Price)
            .ToListAsync();

    public async Task<IEnumerable<Order>> GetAllOrdersForClientAsync(int clientId, bool trackChanges) =>
        await FindByCondition(o => o.ClientId == clientId, trackChanges)
            .OrderBy(o => o.OrderDate)
            .ThenBy(o => o.Price)
            .ToListAsync();

    public void CreateOrderForClient(int clientId, Order order)
    {
        order.ClientId = clientId;
        Create(order);
    }

    public void DeleteOrder(Order order) => Delete(order);
}