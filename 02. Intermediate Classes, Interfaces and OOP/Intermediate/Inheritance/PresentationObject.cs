namespace Association
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void copy()
        {
            Console.WriteLine("object copied to Clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was Duplicated");
        }
    }
}
