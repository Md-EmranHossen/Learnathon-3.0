namespace Composition
{
    public class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            Logger.Log("Wre are installing the applictoin");
        }

    }
}
