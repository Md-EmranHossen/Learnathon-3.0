namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate {  get;private set; }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public int Age   // Calculated Age baished on the another property
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }

        }



    }
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982,1,2));
            Console.WriteLine(person.Age);
        }
    }
    
}
