using Restaurant.DAL.Contracts;

namespace Restaurant.DAL.Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly ApplicationContext _context;
    private readonly Lazy<IClientRepository> _clientRepository;
    private readonly Lazy<IDishRepository> _dishRepository;
    private readonly Lazy<IOrderRepository> _orderRepository;

    public RepositoryManager(ApplicationContext context)
    {
        _context = context;
        _clientRepository = new Lazy<IClientRepository>(() => new ClientRepository(context));
        _dishRepository = new Lazy<IDishRepository>(() => new DishRepository(context));
        _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(context));
    }

    public IClientRepository ClientRepository => _clientRepository.Value;
    public IDishRepository DishRepository => _dishRepository.Value;
    public IOrderRepository OrderRepository => _orderRepository.Value;
    public async Task SaveAsync() => await _context.SaveChangesAsync();
}