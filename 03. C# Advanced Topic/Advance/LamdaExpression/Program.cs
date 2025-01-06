namespace LamdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // number => number * number
            //() => ....
            // x => ....
            // (x,y,z) => ....


            /* Func<int, int> square = number => number * number;
             Console.WriteLine(square(5));*/


            /*
            const int factor = 5;
            Func<int,int> multipler = n => n * factor;
            var result = multipler(10);
            Console.WriteLine(result);
            */
            var books = new BookRepositories().GetBooks();
            var cheapBooks =  books.FindAll(book => book.Price < 10);
            foreach (var book in books) { 
                Console.WriteLine(book.Title);
            }
        }
    }
}
