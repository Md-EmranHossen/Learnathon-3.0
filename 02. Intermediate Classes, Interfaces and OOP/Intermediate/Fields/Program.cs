namespace Fields
{
    internal class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            public readonly List<Order> Orders = new List<Order>();

            public Customer(int id)
            {
                this.Id = id;
            }
            public Customer(int id, string Name)
                :this(id)
            {
                this.Name = Name;
               
            }
            public void Promote()
            {
              //  Orders = new List<Order> ();
            }
        }

        public class Order
        {
           
        }
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();  // Accidently reinitialize the orders fields. so we have to use readonly modifier
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
