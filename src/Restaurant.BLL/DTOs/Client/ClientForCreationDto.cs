using Restaurant.BLL.DTOs.Order;

namespace Restaurant.BLL.DTOs.Client;

public record ClientForCreationDto : ClientForManipulationDto
{
    public IEnumerable<OrderForManipulationDto>? Orders { get; init; }
}