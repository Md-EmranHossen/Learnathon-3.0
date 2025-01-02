namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;
            int c = 6;

            Console.WriteLine(a + b);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);


            // Relational Operator
            Console.WriteLine(a > b);
            Console.WriteLine(a == c);
            Console.WriteLine(c < a);
            Console.WriteLine(!(a != b));

            // Logical Operator
            Console.WriteLine(a > b && a != b);
            Console.WriteLine(a > b || a != b);


            // BitWise Operator
            Console.WriteLine(a | 4);
            Console.WriteLine(c & a);

            // Assignment Operator
            a += 3;
            Console.WriteLine(a);


            // Unary Operator
            b--;
            Console.WriteLine(b);
            a++;
            Console.WriteLine(a);



        }
    }
}
