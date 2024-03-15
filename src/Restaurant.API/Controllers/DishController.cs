using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.DTOs.Dish;

namespace Restaurant.API.Controllers;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class DishController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    
    public DishController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [HttpGet]
    public async Task<IActionResult> GetDishes()
    {
        var dishes = await _serviceManager.DishService.GetDishesAsync(false);
    
        return Ok(dishes);
    }
    
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [HttpGet("{id:int}", Name = "DishById")]
    public async Task<IActionResult> GetDish(int id)
    {
        var dish = await _serviceManager.DishService.GetDishAsync(id, false);

        return Ok(dish);
    }

    [HttpGet("by-min-price/{minPrice:double}")]
    public async Task<IActionResult> GetDishes(double minPrice)
    {
        var dishes = await _serviceManager.DishService.GetDishesAsync(minPrice, false);

        return Ok(dishes);
    }
    
    [HttpGet("with-orders-count")]
    public async Task<IActionResult> GetDishesWithOrdersCount()
    {
        var dishesWithOrdersCount = 
            await _serviceManager.DishService.GetDishesWithOrdersCount();
    
        return Ok(dishesWithOrdersCount);
    }

    [HttpPost]
    public async Task<IActionResult> CreateDish([FromBody]DishForManipulationDto? dish)
    {
        if (dish is null)
        {
            return BadRequest("DishForManipulationDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        var createdDish = await _serviceManager.DishService.CreateDishAsync(dish);

        return CreatedAtRoute("DishById", new { id = createdDish.DishId}, createdDish);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateDish(int id, [FromBody]DishForManipulationDto? dish)
    {
        if (dish is null)
        {
            return BadRequest("DishForManipulationDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        await _serviceManager.DishService.UpdateDishAsync(id, dish, true);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteDish(int id)
    {
        await _serviceManager.DishService.DeleteDishAsync(id, false);

        return NoContent();
    }
}