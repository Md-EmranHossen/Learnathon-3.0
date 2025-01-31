namespace _03_Constructor
{
    public class Customer
    {

        public string Name;

        public Customer(string _name)
        {
            this.Name = _name;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var person = new Customer("Emran");
            }
        }
    }
}
