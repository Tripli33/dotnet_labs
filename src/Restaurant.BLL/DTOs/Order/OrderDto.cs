using Restaurant.DAL.Entities;

namespace Restaurant.BLL.DTOs.Order;

public record OrderDto(int OrderId, int Quantity, DateTime OrderDate, double Price, PaymentType PaymentType, 
    int ClientId, int DishId);