using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.DTOs.Order;
using Restaurant.BLL.Utilities.CustomExceptions;

namespace Restaurant.API.Controllers.V2;

[Authorize]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    
    public ClientController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }
    
    
    [HttpGet("orders")]
    public async Task<IActionResult> GetOrdersForClient()
    {
        
        var clientId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var orders = await _serviceManager.OrderService.GetOrdersForClientAsync(clientId,
            false);

        return Ok(orders);
    }

    [HttpGet("orders/{orderId:int}",  Name = "OrderById")]
    public async Task<IActionResult> GetOrderForClient(int orderId)
    {
        var clientId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var order = await _serviceManager.OrderService.GetOrderForClientAsync(clientId, orderId, false);

        return Ok(order);
    }
    
    [HttpPost("orders")]
    public async Task<IActionResult> CreateOrderForClient([FromBody]OrderForManipulationDto? order)
    {
        var clientId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        var client = await _serviceManager.ClientService.GetClientAsync(clientId, false);

        if (client is null)
        {
            throw new ClientNotFoundException(clientId);
        }
        
        if (order is null)
        {
            return BadRequest("OrderForManipulationDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        var createdOrder = await _serviceManager.OrderService.CreateOrderForClientAsync(clientId, order,
            false);
        
        return CreatedAtRoute("OrderById", new
            {
                clientId = clientId, orderId = createdOrder.OrderId
            }, 
            createdOrder);
    }
    
    [HttpDelete("orders/{orderId:int}")]
    public async Task<IActionResult> DeleteOrderForClient(int orderId)
    {
        var clientId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            
        await _serviceManager.OrderService.DeleteOrderForClientAsync(clientId, orderId, false);

        return NoContent();
    }
}