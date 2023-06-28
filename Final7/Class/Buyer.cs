using Final7.enums;

namespace Final7.Class
{
    public class Buyer : User //Класс Покупатель наследуется и получается всё то, что есть у User
    {       
        public BuyerStatus Status { get; set; } //Поле описывающее статус покупателя. Влияет на бонусы при оформлении заказа.
        public string HomeAddress { get; set; }
        public string PickPointAddress { get; set; }
        
        //Конструктор
        public Buyer(string name)
        {
            Status = BuyerStatus.Common;
            Name = name;
        }
        
        //У пользователя есть функция "Сделать заказ" 
        public void MakeOrder()
        {
            Order order = new Order();
            order.Address = HomeAddress;
            order.customer = this;
            Program.outline.Add(order); //засовываем новый заказ в очередь
        }

        public void RaiseStatus()
        {
            if (this.Status == BuyerStatus.Common)
            {
                this.Status = BuyerStatus.Advanced;
            }
            
            if (this.Status == BuyerStatus.Advanced)
            {
                this.Status = BuyerStatus.VIP;
            }
            
        }
    }
}
