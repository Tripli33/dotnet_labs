using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.Contracts;

namespace Restaurant.API.Controllers;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    
    public OrderController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }
    
    [HttpGet]
    public async Task<IActionResult> GerOrders()
    {
        var orders = await _serviceManager.OrderService.GetOrdersAsync(false);

        return Ok(orders);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        var order = await _serviceManager.OrderService.GetOrderAsync(id, false);

        return Ok(order);
    }
}