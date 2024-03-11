namespace Restaurant.BLL.DTOs.Client;

public record ClientWithAvgDishCountDto(ClientDto? ClientDto, double AvgDishCount);
