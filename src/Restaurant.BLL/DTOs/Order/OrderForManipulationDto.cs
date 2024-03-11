using System.ComponentModel.DataAnnotations;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.DTOs.Order;

public record OrderForManipulationDto
{
    [Required(ErrorMessage = "Quantity is a required field")]
    [Range(1, 50, ErrorMessage = "The Sale field must be between 1 and 50.")]
    public int Quantity { get; init; }
    
    [DataType(DataType.DateTime)]
    public DateTime OrderDate { get; init; } = DateTime.Now;
    
    [EnumDataType(typeof(PaymentType), ErrorMessage = "Wrong payment type")]
    public PaymentType PaymentType { get; init; } = PaymentType.Cash;
    
    [Required(ErrorMessage = "DishId is a required field")]
    public int DishId { get; init; }
};