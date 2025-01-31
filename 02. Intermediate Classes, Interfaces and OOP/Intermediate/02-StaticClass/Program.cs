namespace _02_StaticClass
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hey {0} !This name is {1}", Name, to);
        }
        public static Person Parse(string name)  // This method take a string a return a person object
        {
            var person = new Person();
            person.Name = name;
            return person;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var p = Person.Parse("Emarn");
            p.Introduce("Hossen");
        }
    }
}
