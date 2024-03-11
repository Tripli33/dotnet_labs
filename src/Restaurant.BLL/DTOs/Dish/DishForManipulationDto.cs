using System.ComponentModel.DataAnnotations;

namespace Restaurant.BLL.DTOs.Dish;

public record DishForManipulationDto
{
    private readonly double _price;
    private readonly double _weight;
    
    [Required(ErrorMessage = "Name is a required field")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; init; }
    
    [Required(ErrorMessage = "Price is a required field")]
    [Range(1, 100, ErrorMessage = "The Price field must be between 1 and 100.")]
    public double Price 
    {
        get => _price;
        init => _price = Math.Round(value, 2);
    }
    
    [Required(ErrorMessage = "Weight is a required field")]
    [Range(50, 500, ErrorMessage = "The Weight field must be between 50 and 500.")]
    public double Weight
    {
        get => _weight;
        init => _weight = Math.Round(value, 3);
    }
}