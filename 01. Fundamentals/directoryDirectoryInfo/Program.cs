namespace directoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

           var files =  Directory.GetFiles(@"C:\Users\emran\Desktop\binary-brains", "*.*",SearchOption.AllDirectories);
           foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\emran\Desktop\binary-brains", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(directories);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
