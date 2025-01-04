namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthDatae;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthDatae = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDatae;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(); 
            person.SetBirthdate(DateTime.Now);
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
