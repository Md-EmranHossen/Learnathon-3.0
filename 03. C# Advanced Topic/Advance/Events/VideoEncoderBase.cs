
namespace Events
{
    public class VideoEncoderBase
    {
        public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
    }
}