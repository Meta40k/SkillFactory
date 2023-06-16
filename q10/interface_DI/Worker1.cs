namespace interface_DI;

public class Worker1 : IWorker
{
    private ILogger Logger { get; }
    
    public Worker1(ILogger logger)
    {
        Logger = logger;
    }

    public void Work()
    {
        Logger.Event("Worker 1 is begin");
        Thread.Sleep(3000);
        Logger.Event("Worker 1 is stop");
        Console.WriteLine("-");
        Thread.Sleep(3000);
        
    }
}