namespace q10._5._1
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Введите два числа для суммирования");
            try
            {
                int y = Int32.Parse(Console.ReadLine());
                int x = Int32.Parse(Console.ReadLine());
                var result = new Sum().Summ(y, x);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("нужно корректно заполнить два числа");
            }
        }
    }
}