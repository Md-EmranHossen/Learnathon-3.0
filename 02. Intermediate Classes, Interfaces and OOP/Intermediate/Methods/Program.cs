namespace Methods
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = int.Parse("abc");
            }
            catch (Exception)
            {

                Console.WriteLine("Conversoin is Failed");
            }


            int numebr;
           var result =  int.TryParse("abc",out numebr);
           if(result)
                Console.WriteLine(numebr);

            else Console.WriteLine("Conversion failed");

        }


        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine(calculator.Add(1, 2, 9, 4, 5, 6, 7));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(new int[] { 3, 4, 5, 6, 7, 8, }));
        }


        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                point.Move(null);

                Console.WriteLine("pont is at ({0},{1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("pont is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
