namespace ExceptionHandiling
{
    public class Program
    {
        static void Main(string[] args, StreamReader streamReader)
        {
            StreamReader? streamaReader = null;
            try
            {
                var api = new YouTubeApi();
                var videos =  api.GetVideos("Emran");
                
            }
            catch (Exception ex) {

                
            }
          
        } 
    }
}
