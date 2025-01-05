namespace Composition
{
    public class DbMigr

    {
        private readonly Logger logger;

        public DbMigr(Logger logger)
        {
            this.logger = logger;
        }

        public void Mirgrate()
        {
            logger.Log("We are migrating blah blah...");
        }
    }
}
