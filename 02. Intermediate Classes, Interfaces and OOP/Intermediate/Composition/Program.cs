namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigr(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Mirgrate();
            installer.Install();
        }
    }
}
