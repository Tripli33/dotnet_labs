using System.ComponentModel.DataAnnotations;

namespace Restaurant.BLL.DTOs.Client.Auth;

public record ClientForRegisterDto
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
    
    [Required(ErrorMessage = "Name is a required field")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; init; }
    
    [Required(ErrorMessage = "Address is a required field")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Address is 60 characters.")]
    public string? Address { get; init; }
    
    [Required(ErrorMessage = "Phone is a required field")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; init; }
}