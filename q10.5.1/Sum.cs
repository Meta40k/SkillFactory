namespace q10._5._1;

public class Sum : ISum
{
    public int Summ(int x, int y)
    {
        try
        {
            return x + y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}