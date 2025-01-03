namespace ArrayFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Array length Length
            Console.WriteLine("Length ",numbers.Length);

            // IndexOf (Position of the Array)
            var index = Array.IndexOf(numbers,9);
            Console.WriteLine(index);

            // Clear
            Console.WriteLine("Effect of Clear Methood");
            Array.Clear(numbers,0, 2);
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }

            // Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of a copy array");
            foreach(int x in another)
            {
                Console.WriteLine(x);
            }

            // Sorting
            Array.Sort(another);
            foreach(int y in another)
            {
                Console.WriteLine(y);
            }

            // Reverse
            Console.WriteLine("Applying reverse methood");
            Array.Reverse(another);
            foreach(int z in numbers)
            {
                Console.WriteLine(z);
            }


        }
    }
}
