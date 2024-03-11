using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Contracts;

public interface IDishRepository
{
    Task<Dish?> GetDishByIdAsync(int id, bool trackChanges);
    Task<IEnumerable<Dish>> GetAllDishesAsync(bool trackChanges);
    Task<IEnumerable<Dish>> GetDishesByMinPriceAsync(double minPrice, bool trackChanges);
    Task<IEnumerable<(Dish dish, int ordersCount)>> GetDishesWithOrdersCountAsync();
    void CreateDish(Dish dish);
    void DeleteDish(Dish dish);
}