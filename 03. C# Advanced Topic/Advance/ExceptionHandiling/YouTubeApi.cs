using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandiling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
			try
			{
				throw new Exception("OOPs some low level YouTube error.");
			}
			catch (Exception ex)
			{

				throw new YouTubeException("could not fetch the video from YouTbe",ex);
			}
			return new List<Video>();
        }
    }
}
