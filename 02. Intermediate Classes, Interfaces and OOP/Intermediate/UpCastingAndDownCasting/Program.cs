using System.Collections;

namespace UpCastingAndDownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Text text = new Text();
             Shape shape = text;
             text.Width = 200;
             shape.Width = 100;
             Console.WriteLine(text.Width);*/

           /* StreamReader reader = new StreamReader(new MemoryStream());
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());
            var anotherList = new List<Shape>(); */


            Shape shape = new Text();
            Text text = (Text) shape;
            
            

        }
    }
}
