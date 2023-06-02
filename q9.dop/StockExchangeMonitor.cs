namespace MyNamespace;

public class StockExchangeMonitor
{
    public delegate void PriceChange(int price);
    
    public PriceChange PriceChangeHandler { get; set; }
    

    public void Start()
    {
        while (true)
        {
            var sberbankPrice = new Random().Next(1000);
        }
    }
}