using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.DTOs.Client;
using Restaurant.BLL.DTOs.Order;
using Restaurant.BLL.Utilities.CustomExceptions;

namespace Restaurant.API.Controllers;

[Route("api/clients")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    
    public ClientController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
        var clients = await _serviceManager.ClientService.GetClientsAsync(false);

        return Ok(clients);
    }

    [HttpGet("with-avg-dish-count")]
    public async Task<IActionResult> GetClientsWithAvgDishCount()
    {
        var clientsWithAvgDishCount =
            await _serviceManager.ClientService.GetClientsWithAvgDishCountAsync();

        return Ok(clientsWithAvgDishCount);
    }

    [HttpGet("by-dish-id/{dishId:int}")]
    public async Task<IActionResult> GetClientsByDishId(int dishId)
    {
        var clients = await _serviceManager.ClientService.GetClientsAsync(dishId);

        return Ok(clients);
    }

    [HttpGet("{id:int}", Name = "ClientById")]
    public async Task<IActionResult> GetClient(int id)
    {
        var client = await _serviceManager.ClientService.GetClientAsync(id, false);

        return Ok(client);
    }
    
    [HttpGet("{clientId:int}/orders")]
    public async Task<IActionResult> GetOrdersForClient(int clientId)
    {
        var orders = await _serviceManager.OrderService.GetOrdersForClientAsync(clientId,
            false);

        return Ok(orders);
    }

    [HttpGet("{clientId:int}/orders/{orderId:int}", Name = "OrderForClientById")]
    public async Task<IActionResult> GetOrderForClient(int clientId, int orderId)
    {
        var order = await _serviceManager.OrderService.GetOrderForClientAsync(clientId, orderId, false);

        return Ok(order);
    }

    [HttpPost]
    public async Task<IActionResult> CreateClient([FromBody]ClientForCreationDto? client)
    {
        if (client is null)
        {
            return BadRequest("ClientForManipulationDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        var createdClient = await _serviceManager.ClientService.CreateClientAsync(client);

        return CreatedAtRoute("ClientById", new { id = createdClient.ClientId}, createdClient);
    }

    [HttpPost("{clientId:int}/orders")]
    public async Task<IActionResult> CreateOrderForClient(int clientId, 
        [FromBody]OrderForManipulationDto? order)
    {
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
        
        return CreatedAtRoute("OrderForClientById", new
            {
                clientId = clientId, orderId = createdOrder.OrderId
            }, 
            createdOrder);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateClient(int id, [FromBody]ClientForUpdateDto? client)
    {
        if (client is null)
        {
            return BadRequest("ClientForManipulationDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        await _serviceManager.ClientService.UpdateClientAsync(id, client, true);

        return NoContent();
    }

    [HttpPut("{clientId:int}/orders/{orderId:int}")]
    public async Task<IActionResult> UpdateOrderForClient(int clientId, int orderId, 
        [FromBody]OrderForManipulationDto? order)
    {
        if (order is null)
        {
            return BadRequest("OrderForManipulationDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        await _serviceManager.OrderService.UpdateOrderForClient(clientId, orderId, order, 
            false, true);
        
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteClient(int id)
    {
        await _serviceManager.ClientService.DeleteClientAsync(id, false);

        return NoContent();
    }

    [HttpDelete("{clientId:int}/orders/{orderId:int}")]
    public async Task<IActionResult> DeleteOrderForClient(int clientId, int orderId)
    {
        await _serviceManager.OrderService.DeleteOrderForClientAsync(clientId, orderId, false);

        return NoContent();
    }
}