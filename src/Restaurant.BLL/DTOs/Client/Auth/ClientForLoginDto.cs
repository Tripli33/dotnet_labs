using System.ComponentModel.DataAnnotations;

namespace Restaurant.BLL.DTOs.Client.Auth;

public record ClientForLoginDto
{
    [Required(ErrorMessage = "Email is a required field")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; init; }

    [Required(ErrorMessage = "Password is a required field")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", 
        ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one digit")]
    [DataType(DataType.Password)]
    public string? Password { get; init; }
}