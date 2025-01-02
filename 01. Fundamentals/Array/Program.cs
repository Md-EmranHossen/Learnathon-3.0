namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Agaes = new int[6] {1,2,3,4,5,6};

            foreach(int x in Agaes)
            {
                Console.WriteLine(x);
            }

            var flags = new bool[4];

            flags[0] = true;

            foreach(bool k in flags)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(flags[3]);


            var names = new string[5]{"emran", "Hossen","Safi","ehsan","Shakib"};




        }
    }
}
