namespace ExceptionHandiling
{
    public class YouTubeException : Exception
	{
		public YouTubeException(string message, Exception innerExcepton)
			:base(message,innerExcepton)
		{

		}
	}
}
