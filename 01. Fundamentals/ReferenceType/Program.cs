namespace ReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10; 
            var b = a;
            b++;
            Console.WriteLine(a); // Integers are value type
            Console.WriteLine(b);
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));


            var arr1 = new int[3] { 1, 2, 3 };  // Arrays are class types
            var arr2 = arr1;
            arr2[0] = 0;
            Console.WriteLine(string.Format("array[0]: {0}, array2[0]: {1} ", arr1[0], arr2[0]));




        }
    }
}
