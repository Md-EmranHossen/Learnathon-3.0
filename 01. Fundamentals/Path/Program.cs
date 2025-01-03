using System.IO;
using System;
namespace Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\emran\Desktop\binary-brains";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine(Path.GetExtension(path));
        }
    }
}
