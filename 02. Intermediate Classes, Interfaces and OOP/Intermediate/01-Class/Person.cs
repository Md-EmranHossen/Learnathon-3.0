namespace _01_Class
{
    public class Person
    {
        public string Name;
        
        public void Introduce(string to)
        {
            Console.WriteLine("Hey {0} !This name is {1}",Name, to);
        }

    }
}
