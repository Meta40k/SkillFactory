namespace interface_DI;

public class Worker3 : IWorker
{
    private ILogger Logger { get; }
    
    public Worker3(ILogger logger)
    {
        Logger = logger;
    }

    public void Work()
    {
        Logger.Event("Worker 3 is begin");
        Thread.Sleep(3000);
        Logger.Event("Worker 3 is stop");
        Console.WriteLine("-");
        Thread.Sleep(3000);
        
    }
}