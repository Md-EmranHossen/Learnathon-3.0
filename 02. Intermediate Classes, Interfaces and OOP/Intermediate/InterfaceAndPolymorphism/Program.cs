namespace InterfaceAndPolymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VidoeEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel);
            encoder.RegisterNotificationChannel(new SmsNotificationChannel);

            encoder.Encode(new Video());
        }
    }
}
