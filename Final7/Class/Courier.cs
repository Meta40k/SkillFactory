namespace Final7.Class;

class Courier : User //Класс курьер. Так же наследуется от User, для получении информации о доставке.  
{

    public void Deliver(User user)
    {
        Delivery delivery = new Delivery();
    }
}