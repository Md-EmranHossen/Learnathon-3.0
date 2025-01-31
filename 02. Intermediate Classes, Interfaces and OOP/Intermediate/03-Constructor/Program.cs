namespace _03_Constructor
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer(string _name)
        {
            this.Name = _name;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var customer = new Customer("Emran");
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);

            }
        }
    }
}
