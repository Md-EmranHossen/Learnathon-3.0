namespace InterfaceAndExtensibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"c:\Project\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
