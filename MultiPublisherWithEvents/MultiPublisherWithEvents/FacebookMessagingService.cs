using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents
{
    public class FacebookMessagingService : MessagingServiceBase
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine($"Enviando Mensaje por Facebook: {message}");
        }

        public FacebookMessagingService()
        {
            this.ServiceName = "Facebook";
        }
    }
}
