using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Repository;

public class DishRepository : RepositoryBase<Dish>, IDishRepository
{
    public DishRepository(ApplicationContext context) : base(context)
    {
    }

    public async Task<Dish?> GetDishByIdAsync(int id, bool trackChanges) => 
        await FindByCondition(d => d.DishId == id, trackChanges)
            .SingleOrDefaultAsync();
    
    public async Task<IEnumerable<Dish>> GetAllDishesAsync(bool trackChanges) => 
        await FindAll(trackChanges)
            .OrderBy(d => d.Name)
            .ThenBy(d => d.Price)
            .ToListAsync();
    
    public async Task<IEnumerable<Dish>> GetDishesByMinPriceAsync(double minPrice, bool trackChanges) => 
        await FindByCondition(d => d.Price >= minPrice, trackChanges)
            .OrderBy(d => d.Name)
            .ThenBy(d => d.Price)
            .ToListAsync();

    public async Task<IEnumerable<(Dish dish, int ordersCount)>> GetDishesWithOrdersCountAsync()
    {
        var dishesWithOrders = await Context.Dishes
            .OrderBy(d => d.Name)
            .Include(d => d.Orders)
            .ToListAsync(); 

        return dishesWithOrders.Select(d =>
        (
            dish: d,
            ordersCount: d.Orders?.Count ?? 0
        ));
    }
    
    public void CreateDish(Dish dish) => Create(dish);

    public void DeleteDish(Dish dish) => Delete(dish);
}