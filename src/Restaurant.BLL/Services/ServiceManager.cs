using AutoMapper;
using Restaurant.BLL.Contracts;
using Restaurant.DAL.Contracts;

namespace Restaurant.BLL.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IClientService> _clientService;
    private readonly Lazy<IDishService> _dishService;
    private readonly Lazy<OrderService> _orderService;

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _clientService = new Lazy<IClientService>(() => new ClientService(repositoryManager, mapper));
        _dishService = new Lazy<IDishService>(() => new DishService(repositoryManager, mapper));
        _orderService = new Lazy<OrderService>(() => new OrderService(repositoryManager, mapper));
    }

    public IClientService ClientService => _clientService.Value;
    public IDishService DishService => _dishService.Value;
    public IOrderService OrderService => _orderService.Value;
}