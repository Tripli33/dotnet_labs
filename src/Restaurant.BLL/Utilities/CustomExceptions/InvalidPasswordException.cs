namespace Restaurant.BLL.Utilities.CustomExceptions;

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException() : base("Invalid password.")
    {
    }
}