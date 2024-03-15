namespace Restaurant.BLL.DTOs.Client.Auth;

public record ClientWithTokenDto
{
    public int ClientId { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public int Sale { get; set; }
    public string? Token { get; set; }
}