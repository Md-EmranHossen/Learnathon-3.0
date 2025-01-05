namespace Association
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FrontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("we added a link to " + url);
        }
    }
}
