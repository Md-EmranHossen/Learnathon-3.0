using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {


            string post = "This is supposed to be a very long long post blah blah blah...";

            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>();
            Console.WriteLine(shortenedPost);
        }

    }
}
