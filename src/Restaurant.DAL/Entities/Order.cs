namespace Restaurant.DAL.Entities;

public class Order
{
    public int OrderId { get; set; }
    public int Quantity { get; set; }
    public DateTime OrderDate { get; set; }
    public double Price { get; set; }
    public PaymentType PaymentType { get; set; } = PaymentType.Cash;
    public int ClientId { get; set; }
    public int DishId { get; set; }
    public Client? Client { get; set; }
    public Dish? Dish { get; set; }
}