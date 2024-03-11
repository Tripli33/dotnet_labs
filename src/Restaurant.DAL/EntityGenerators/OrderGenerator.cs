using Restaurant.DAL.Entities;

namespace Restaurant.DAL.EntityGenerators;
// WARNING: This class is intended for initial data generation only
public static class OrderGenerator
{
    private static readonly Random Random = new();
    
    public static IEnumerable<Order> GenerateOrders(int numberOfEntities, int maxQuantity, int maxClientId,
        int maxDishId, DateTime minDate)
    {
        var timeSpan = DateTime.Now - minDate;
        var range = timeSpan.TotalSeconds;

        return Enumerable.Range(1, numberOfEntities).Select(i => 
            new Order()
            {
                OrderId = i,
                Quantity = Random.Next(1, maxQuantity),
                OrderDate = minDate.AddSeconds(Random.NextDouble() * range),
                PaymentType = (PaymentType)Random.Next(Enum.GetValues<PaymentType>().Length),
                ClientId = Random.Next(1, maxClientId),
                DishId = Random.Next(1, maxDishId),
            }
        );
    }
}