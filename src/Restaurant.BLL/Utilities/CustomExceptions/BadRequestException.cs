namespace Restaurant.BLL.Utilities.CustomExceptions;

public abstract class BadRequestException : Exception
{
    protected BadRequestException(string? message) : base(message)
    {
    }
}