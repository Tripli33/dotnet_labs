using Restaurant.BLL.DTOs.Dish;

namespace Restaurant.BLL.Contracts;

public interface IDishService
{
    Task<DishDto> GetDishAsync(int id, bool trackChanges);
    Task<IEnumerable<DishDto>> GetDishesAsync(bool trackChanges);
    Task<IEnumerable<DishDto>> GetDishesAsync(double minPrice, bool trackChanges);
    Task<IEnumerable<DishWithOrdersDto>> GetDishesWithOrdersCount();
    Task<DishDto> CreateDishAsync(DishForManipulationDto dishForManipulationDto);
    Task UpdateDishAsync(int id, DishForManipulationDto dishForManipulationDto, bool trackChanges);
    Task DeleteDishAsync(int id, bool trackChanges);
}