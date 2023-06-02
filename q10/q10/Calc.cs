namespace interfacespace;

public class Calc : ICalc
{
    public void Sum(int a, int b)
    {
        try
        {
            Console.WriteLine(a + b);
        }
        catch (Exception ex)
        {
            Console.WriteLine("надо было вводить корректные значения, а не вот это вот всё");
        }
    }
}