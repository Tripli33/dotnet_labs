namespace Restaurant.BLL.Utilities.CustomExceptions;

public abstract class NotFoundException : Exception
{
    protected NotFoundException(string? message) : base(message)
    {
    }
}