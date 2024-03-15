namespace Restaurant.BLL.Utilities.CustomExceptions;

public sealed class ClientNotFoundException : NotFoundException
{
    public ClientNotFoundException(int id) 
        : base($"The client with id: {id} doesn't exist in the database.")
    {
    }

    public ClientNotFoundException(string email)
        : base($"The client with email: {email} doesn't exist in the database.")
    {
    }
}