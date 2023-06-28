namespace Final7.Class;

//Класс курьер. Так же наследуется от User, для получении информации о доставке.  
class Courier : User 
{
    private Order currentOrder; //делаю поле private, так как информацию о заказе может знать только сам курьер

    //У Курьера есть кнопка "Что там по доставкам" которая выдаёт курьеру 1 заказ, а получает этот заказ из очереди
    public void CheckAndTakeOrder()
    {
        if (Program.outline.LastOrDefault() != null)
        {
            currentOrder = Program.outline.LastOrDefault()!; //последний заказ присваивается курьеру
            Program.outline.RemoveAt(Program.outline.Count -1); //удаляем этот заказ из пула ордеров.
        }
    }

    public void Go() //отправляемся в дорогу
    {
        Console.WriteLine($"еду по адресу {currentOrder.Address}");
    }
}