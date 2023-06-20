namespace q10._5._2;

public class Logger : ILogger
{
    public void Event(string message)
    {
        Console.WriteLine(message);
    }
}