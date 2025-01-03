namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4,5,6};
            numbers.Add(1); // Initilize

            foreach(var x in numbers)
            {
                Console.WriteLine(x);
            }
            // Add another array to the list
            Console.WriteLine("After adding a array in the list");
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Index of
            Console.WriteLine("Index of ", numbers.IndexOf( 1));
            Console.WriteLine("Index of ", numbers.LastIndexOf(1));

            // Count of objects
            Console.WriteLine("Number of object in the list", numbers.Count);

            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //here first instance remove using this function of one

            // TO remvoe all instances of one

           /* foreach(var number in numbers)
            {
                if (number == 1)
                {
                    numbers.Remove(1);
                }
            }*/

           

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }


            /* foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/


            // Clear methood
            numbers.Clear();
            Console.WriteLine("Count",numbers.Count);
        }
    }
}
