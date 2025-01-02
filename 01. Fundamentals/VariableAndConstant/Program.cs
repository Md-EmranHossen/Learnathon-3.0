namespace VariableAndConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var length = 4.5;
            byte Number = 3;
            int cnt = 10;
            float price = 34.5f;
            char ch = 'E';
            string name = "Emran";
            const float PI = 3.1416f;
            Console.WriteLine(name);
            Console.WriteLine(ch);
            Console.WriteLine(cnt);
            Console.WriteLine(price);
            Console.WriteLine(Number);
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0},{1}", int.MinValue, int.MaxValue);
        }
    }
}
