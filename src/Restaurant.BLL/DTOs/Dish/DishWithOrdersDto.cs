namespace Restaurant.BLL.DTOs.Dish;

public record DishWithOrdersDto(DishDto? Dish, int OrdersCount);