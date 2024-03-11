using System.ComponentModel.DataAnnotations;

namespace Restaurant.BLL.DTOs.Client;

public abstract record ClientForManipulationDto
{
    [Required(ErrorMessage = "Name is a required field")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; init; }
    
    [Required(ErrorMessage = "Address is a required field")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Address is 60 characters.")]
    public string? Address { get; init; }
    
    [Required(ErrorMessage = "Phone is a required field")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; init; }
    
    [Range(0, 50, ErrorMessage = "The Sale field must be between 0 and 50.")]
    public int Sale { get; init; }
}