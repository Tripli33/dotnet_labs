namespace Restaurant.BLL.DTOs.Client.Auth;

public record ClientDto(int ClientId, string Email, string? Name, string? Address, string? Phone, int Sale);