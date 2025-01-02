using System.Reflection;

namespace Enum
{
    public enum ShippingMethood
    {
        RegularMail = 1,
        RgirsterdMail = 2,
        Expose = 3
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var methood = ShippingMethood.Expose;

            Console.WriteLine((int)methood);

            var method1 = 3;

            Console.WriteLine((ShippingMethood)method1);

            Console.WriteLine(methood.ToString());

            var methoodName = "Expose";

            var shippingMethod = (ShippingMethood)Enum.Parse(typeof(ShippingMethood), methodName);

        }
    }
}
