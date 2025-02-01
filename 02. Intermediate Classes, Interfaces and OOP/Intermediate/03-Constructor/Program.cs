namespace _03_Constructor
{
    public class Order 
    {

    }
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
           // Orders = new List<Order>();
        }
        public Customer(string _name)
        {
            this.Name = _name;
        }
        public Customer(int _id, string _name)
        {
            this.Id = _id;
            this.Name = _name;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var customer = new Customer(1,"Erman");
                var order = new Order();
                customer.Orders.Add(order); //
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
            }
        }
    }
}
