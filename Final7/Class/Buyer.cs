namespace Final7.Class
{
    class Buyer : User //Класс Покупатель наследуется и получается всё то, что есть у User
    {       
        public BuyerStatus Status { get; set; } //Поле описывающее статус покупателя. Влияет на бонусы при оформлении заказа.

        public string HomeAddress { get; set; }
        
    }
}
