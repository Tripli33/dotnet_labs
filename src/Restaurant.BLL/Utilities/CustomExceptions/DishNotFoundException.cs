namespace Restaurant.BLL.Utilities.CustomExceptions;

public class DishNotFoundException : NotFoundException
{
    public DishNotFoundException(int id) 
        : base($"The dish with id: {id} doesn't exist in the database.")
    {
    }
}