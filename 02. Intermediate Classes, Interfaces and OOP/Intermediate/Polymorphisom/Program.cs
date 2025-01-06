namespace Polymorphisom
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Ractangle());

            var canvas = new Canvas();
            canvas.DrawShape(shapes);
        }
    }
}
