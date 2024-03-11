namespace Restaurant.BLL.DTOs.Client;

public record ClientDto(int ClientId, string? Name, string? Address, string? Phone, int Sale);