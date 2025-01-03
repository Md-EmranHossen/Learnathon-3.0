using System.Text;

namespace StringBuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder
                .Append('_', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('_', 10)
                .Replace('_', '+')
                .Remove(0, 10)
                .Insert(0,new string('_',10));

            Console.WriteLine(builder);

            // No searching methood allow in string builder

            Console.Write(builder[0]);

        }
    }
}
