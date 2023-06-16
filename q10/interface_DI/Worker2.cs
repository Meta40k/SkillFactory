namespace interface_DI;

public class Worker2 : IWorker
{
    private ILogger Logger { get; }
    
    public Worker2(ILogger logger)
    {
        Logger = logger;
    }

    public void Work()
    {
        Logger.Event("Worker 2 is begin");
        Thread.Sleep(3000);
        Logger.Event("Worker 2 is stop");
        Console.WriteLine("-");
        Thread.Sleep(3000);
        
    }
}