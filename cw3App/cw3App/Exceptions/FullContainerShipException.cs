namespace cw3App;

public class FullContainerShipException : Exception
{
    public FullContainerShipException()
    {
    }

    public FullContainerShipException(string? message) : base(message)
    {
    }

    public FullContainerShipException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}