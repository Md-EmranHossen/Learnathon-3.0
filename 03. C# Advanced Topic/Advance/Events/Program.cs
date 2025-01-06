namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Title = "Video 1"
            };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailservice = new MailService(); // Subscriber
            var messageService = new MessageService();
            videoEncoder.VideoEncoded += mailservice.OnvideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video, Video);
        }
    }
}
