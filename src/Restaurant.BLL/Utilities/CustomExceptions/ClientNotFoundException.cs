namespace Restaurant.BLL.Utilities.CustomExceptions;

public sealed class ClientNotFoundException : NotFoundException
{
    public ClientNotFoundException(int id) 
        : base($"The client with id: {id} doesn't exist in the database.")
    {
    }
}