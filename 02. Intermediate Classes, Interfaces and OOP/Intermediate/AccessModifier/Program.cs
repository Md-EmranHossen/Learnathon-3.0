namespace AccessModifier
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthDate) 
        {
        _birthDate = birthDate;
        }

        public DateTime GetBirthdate() 
        { 
            return _birthDate; 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           var person = new Person();
           person.SetBirthDate(new DateTime(1982,1,1));
           Console.WriteLine(person.GetBirthdate());
        }
    }
}
