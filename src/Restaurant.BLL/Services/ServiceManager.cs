using AutoMapper;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.Contracts.Auth;
using Restaurant.BLL.Services.Auth;
using Restaurant.DAL.Contracts;

namespace Restaurant.BLL.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IClientService> _clientService;
    private readonly Lazy<IDishService> _dishService;
    private readonly Lazy<OrderService> _orderService;
    private readonly Lazy<AuthService> _authService;

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, IPasswordHasher passwordHasher, 
        IJwtProvider jwtProvider)
    {
        _clientService = new Lazy<IClientService>(() => new ClientService(repositoryManager, mapper));
        _dishService = new Lazy<IDishService>(() => new DishService(repositoryManager, mapper));
        _orderService = new Lazy<OrderService>(() => new OrderService(repositoryManager, mapper));
        _authService =
            new Lazy<AuthService>(() => new AuthService(repositoryManager, jwtProvider, passwordHasher, mapper));
    }

    public IClientService ClientService => _clientService.Value;
    public IDishService DishService => _dishService.Value;
    public IOrderService OrderService => _orderService.Value;
    public IAuthService AuthService => _authService.Value;
}