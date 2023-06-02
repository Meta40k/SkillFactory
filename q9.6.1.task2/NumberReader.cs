namespace DelegatePractices;

public class NumberReader
{
    public delegate void NumberEneteredDelegate(int num);

    public event NumberEneteredDelegate NumberEnenteredDelegateEvent;

    public void Read()
    {
        Console.WriteLine("");
        Console.WriteLine("Для сортировки А-Я, нажмите 1");
        Console.WriteLine("Для сортировки Я-А, нажмите 2");
        
        int number = Convert.ToInt32(Console.ReadLine());

        NumnerEntered(number);
    }

    protected virtual void NumnerEntered(int num)
    {
        NumberEnenteredDelegateEvent?.Invoke(num);
    }
}