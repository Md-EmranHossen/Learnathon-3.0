namespace Polymorphisom
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Deaw a Circle");
        }

    }
    public class Rectangle : Shape
    {

      public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }

    }
    public class Ractangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Deaw a Circle");
        }

    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {

        }
    }
}
