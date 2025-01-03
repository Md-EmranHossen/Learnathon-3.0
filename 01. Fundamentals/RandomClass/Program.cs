namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random class generate random numbers

            var random = new Random();
            var buffer = new char[10];

            for(var i = 0; i < 10; i++)
            {
                //Console.WriteLine(random.Next(1,10));
                Console.Write((char)('a' + random.Next(0, 26)));
                var password = new string(buffer);
            }
            Console.WriteLine();

            // ASCII
            Console.WriteLine((int)'A');
        }
    }
}
