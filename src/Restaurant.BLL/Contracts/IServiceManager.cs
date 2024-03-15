using Restaurant.BLL.Contracts.Auth;

namespace Restaurant.BLL.Contracts;

public interface IServiceManager
{
    IClientService ClientService { get; }
    IDishService DishService { get; }
    IOrderService OrderService { get; }
    IAuthService AuthService { get; }
}