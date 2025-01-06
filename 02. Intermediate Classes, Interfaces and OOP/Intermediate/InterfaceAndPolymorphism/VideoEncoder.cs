using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndPolymorphism
{
    private readonly IList<INotificationChannel> _notficatoinChannels;
    public class VidoeEncoder
    {

        public VidoeEncoder()
        {
            _notifiacationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var channesl in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        { 
            _notificationChannels.Add(channel);
        }
    }
    
}
