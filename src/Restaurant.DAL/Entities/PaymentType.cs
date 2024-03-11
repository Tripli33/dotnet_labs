using System.Text.Json.Serialization;

namespace Restaurant.DAL.Entities;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PaymentType
{
    Card = 0,
    Cash = 1
}