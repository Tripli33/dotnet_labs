namespace Restaurant.BLL.Utilities.CustomExceptions;

public class OrderNotFoundException : NotFoundException
{
    public OrderNotFoundException(int id) 
        : base($"The order with id: {id} doesn't exist in the database.")
    {
    }
}