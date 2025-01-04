namespace Properties
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
           get
           {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
           }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));
           
            Console.WriteLine(person.Age);
            
        }
    }
}
