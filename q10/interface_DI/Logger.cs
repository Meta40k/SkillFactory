namespace interface_DI;

public class Logger : ILogger
{
    public void Event(string message)
    {
        Console.WriteLine(message);
    }

    public void Error(string message)
    {
        Console.WriteLine(message);

    }
}