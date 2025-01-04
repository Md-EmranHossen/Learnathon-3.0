namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttoCookie();
            cookie["names"] = "Emran";
            Console.WriteLine(cookie["names"]);
        }
    }
}
