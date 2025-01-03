namespace Summarising_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be really really really really really long text";
            Console.WriteLine(StringUtility.SummerizeText(sentence));
        }
    }
}
