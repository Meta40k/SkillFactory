using Final7.Class;

internal class Program
{
    //Все создаваемые ордеры, попадют в эту очередь
    public static List<Order> outline = new();
    
    private static void Main(string[] args)
    {
        //Взяли на работу двух курьеров.
        List<Courier> Bedolagi = new List<Courier>();
        var biba = new Courier();
        var boba = new Courier();
        Bedolagi.Add(biba);
        Bedolagi.Add(boba);
        
        //Регистрируем двух пользователей
        Buyer Denis = new();
        Buyer Vova = new();

        Console.WriteLine(outline.Count);
        Denis.MakeOrder();
        Console.WriteLine(outline.Count);
        Vova.MakeOrder();
        Console.WriteLine(outline.Count);


    }
}