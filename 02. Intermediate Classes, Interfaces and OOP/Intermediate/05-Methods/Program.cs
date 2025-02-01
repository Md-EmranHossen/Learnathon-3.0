namespace _05_Methods
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point p)
        {
            ArgumentNullException.ThrowIfNull(p);
            Move(p.x, p.y);
        }
    }


    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var p in numbers)
            {
                sum = sum + p;
            }

            return sum;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
                


        }


        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 3, 4, 5, 6));
            Console.WriteLine(calculator.Add(new int[] { 2, 3, 4, 5, 6 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(12, 23);
                point.Move(null);
                Console.WriteLine("Point is at ({0},{1})", point.x, point.y);
                point.Move(34, 56);
                Console.WriteLine("Point is at ({0},{1})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unExpectd Error Occurs");
            }
        }
    }
}

