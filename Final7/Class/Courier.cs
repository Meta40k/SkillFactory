namespace Final7.Class;

class Courier : User //Класс курьер. Так же наследуется от User, для получении информации о доставке.  
{

    //У Курьера есть кнопка "Что там по доставкам" которая выдаёт курьеру 1 заказ, а получает этот заказ из очереди
    Order CheckOrder(Outline outline)
    {
        return outline.ListOrder.LastOrDefault();
    }
}