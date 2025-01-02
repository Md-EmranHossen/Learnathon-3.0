using NonPrimitiveType.Math;
using System.Collections.Specialized;

namespace NonPrimitiveType
{
    public class Program
    {
        static void Main(string[] args)
        {
            var emran = new Person();
            emran.FirstName = "Emran";
            emran.LastName = "Hossen";
            emran.Introduce();

           var calaculator = new Calculator();
           var result =  calaculator.Add(4, 8);
           Console.WriteLine(result);
        }
    }
}
