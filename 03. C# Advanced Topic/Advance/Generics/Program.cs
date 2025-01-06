namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }


    public class GenericDictionary<TKey, Tvalue>
    {
        public void Add(TKey key, Tvalue value)
        {

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            /*var numbers = new GenericList<int>();
            numbers.Add(1);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());*/

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("value is "  + number.GetValueOrDefault());
          
            
        }
    }
}
