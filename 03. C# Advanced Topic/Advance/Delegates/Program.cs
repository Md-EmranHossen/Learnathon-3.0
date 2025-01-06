namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            processor.Process("photo.jpg", filterHandler);
            filterHandler += RemoveRedEyeFilter;
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }

    }
}
