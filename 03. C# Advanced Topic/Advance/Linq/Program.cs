namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// LINQ Query Operators
            var cheaperBooks = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            //LINQ Extension Methods [Most Powerfull]
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b =>b.Title);
           

            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }*/




            var books = new BookRepository().GetBooks();
            // var book =  books.SingleOrDefault(b => b.Title == "ASP .NET MVC++");
            var book = books.First(b => b.Title == "C# Advanced Topics");

            //Console.WriteLine(book == null);
            //Console.WriteLine(book.Title);

            Console.WriteLine(book.Title + " " + book.Price);

        }
    }
}
