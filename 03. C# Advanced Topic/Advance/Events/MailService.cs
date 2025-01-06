namespace Events
{
    public class MailService
    {
        public void OnvideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mailservice Sending an Email ...." + args.Video.Title);
        }
    }
}
