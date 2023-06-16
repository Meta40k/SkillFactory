namespace interface_DI;

public interface ILogger
{
    void Event(string message);
    void Error(string message);
}