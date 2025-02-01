namespace _04_ObjectInitalizers
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBitrh;
        internal class Program
        {
            static void Main(string[] args)
            {
                var person = new Person
                {
                    FirstName = "Emran",
                    LastName = "Hossen"
                };
                Console.WriteLine(person.FirstName);
            }
        }
    }
}