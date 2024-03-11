namespace Restaurant.DAL.Entities;

public class Dish
{
    public int DishId { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public double Weight { get; set; }
    public ICollection<Order>? Orders { get; set; }
}