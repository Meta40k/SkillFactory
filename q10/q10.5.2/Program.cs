namespace q10._5._2
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Logger logger = new Logger();
            
            Console.WriteLine("Введите два числа для суммирования");
            try
            {
                int y = Int32.Parse(Console.ReadLine());
                int x = Int32.Parse(Console.ReadLine());
                var cacl1 = new Calculator(logger);
                Console.WriteLine(cacl1.Summm(y, x));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("нужно корректно заполнить два числа");
            }

            ILogger loge = new Logger();
            Console.WriteLine(loge);
        }
    }
}