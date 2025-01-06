using System.Security.Cryptography.X509Certificates;

namespace AbstraClass
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Weight { get; set; }

        public abstract void Draw();

        public void copy()
        {
            Console.WriteLine("Copy");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
       
    }
}
