namespace Final7.Class
{
    public class Order
    {
        public Guid Id;
        public string Description;
        public string Address;
        public User customer;

        private List<Product> _products;

        public Order()
        {
            Id = new Guid();
        }
        public void DisplayAddress()
        {

        }
    }
}
