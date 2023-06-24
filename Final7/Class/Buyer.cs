using Final7.enums;

namespace Final7.Class
{
    class Buyer : User //Класс Покупатель наследуется и получается всё то, что есть у User
    {       
        public BuyerStatus Status { get; set; } //Поле описывающее статус покупателя. Влияет на бонусы при оформлении заказа.
        public string HomeAddress { get; set; }
        public string PickPointAddress { get; set; }
        private Order outline;
        
        //Конструктор
        public Buyer()
        {
            Status = BuyerStatus.Common;
        }
        
        //У пользователя есть функция "Сделать заказ"
        Order MakeOrder()
        {
            Order order = new Order();
            order.Address = HomeAddress;
            outline.Add(outline);
            return order;
        }
    }
}
