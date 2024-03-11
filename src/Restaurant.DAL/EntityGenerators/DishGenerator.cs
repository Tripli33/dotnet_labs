using Restaurant.DAL.Entities;

namespace Restaurant.DAL.EntityGenerators;
// WARNING: This class is intended for initial data generation only
public static class DishGenerator
{
    private static readonly Random Random = new();

    private static readonly List<string> DishName = new()
    {
        "Spaghetti Carbonara",
        "Chicken Alfredo",
        "Beef Stroganoff",
        "Shrimp Scampi",
        "Margherita Pizza",
        "Caesar Salad",
        "Chicken Parmesan",
        "Grilled Salmon",
        "Beef Tacos",
        "Pad Thai",
        "Hamburger",
        "Fish and Chips",
        "Chicken Tikka Masala",
        "BBQ Ribs",
        "Mushroom Risotto",
        "Sushi",
        "Lobster Bisque",
        "Vegetable Stir-Fry",
        "Caprese Salad",
        "Roast Beef",
        "Eggplant Parmesan",
        "Pho",
        "Tuna Salad",
        "Pesto Pasta",
        "Chicken Curry",
        "Clam Chowder",
        "Shepherd's Pie",
        "Pulled Pork Sandwich",
        "Beef Wellington",
        "Lemon Chicken",
        "Tomato Soup",
        "Shrimp Cocktail",
        "Fried Chicken",
        "Beef Bourguignon",
        "Greek Salad",
        "Crispy Duck",
        "Ratatouille",
        "Steak Frites",
        "French Onion Soup"
    };
    
    public static IEnumerable<Dish> GenerateDishes(int numberOfEntities, int minPrice, int maxPrice, int minWeight,
        int maxWeight) => 
        Enumerable.Range(1, numberOfEntities).Select(i => new Dish()
        {
            DishId = i,
            Name = DishName[Random.Next(DishName.Count)],
            Price = Math.Round(Random.NextDouble() * (maxPrice - minPrice) + minPrice, 2),
            Weight = Math.Round(Random.NextDouble() * (maxWeight - minWeight) + minWeight, 3)
        });
}