namespace interface_DI
{
    class Program
    {
        static ILogger Logger { get; set; }
        
        static void Main(string[] agrs)
        {
            Logger = new Logger();

            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);
            var worker3 = new Worker3(Logger);
            
            worker1.Work();
            worker2.Work();
            worker3.Work();
            Console.WriteLine(1);
        }
    }
    
}