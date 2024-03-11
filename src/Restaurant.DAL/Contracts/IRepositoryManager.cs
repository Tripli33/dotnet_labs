namespace Restaurant.DAL.Contracts;

public interface IRepositoryManager
{
    public IClientRepository ClientRepository { get; }
    public IDishRepository DishRepository { get; }
    public IOrderRepository OrderRepository { get; }
    Task SaveAsync();
}