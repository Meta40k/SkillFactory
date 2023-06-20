namespace q10._5._2;

public class Calculator : ICalculator
{
    private ILogger Logger { get; }

    public Calculator(ILogger logger)
    {
        Logger = logger;
    }

    public int Summm(int x, int y)
    {
        Console.WriteLine("Запись в лог");
        Logger.Event("ок");
        return x+y;
    }
}