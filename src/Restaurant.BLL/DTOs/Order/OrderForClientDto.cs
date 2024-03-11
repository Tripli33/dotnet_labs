using Restaurant.DAL.Entities;

namespace Restaurant.BLL.DTOs.Order;

public record OrderForClientDto(int OrderId, int Quantity, DateTime OrderDate, double Price, PaymentType PaymentType, 
    int DishId);