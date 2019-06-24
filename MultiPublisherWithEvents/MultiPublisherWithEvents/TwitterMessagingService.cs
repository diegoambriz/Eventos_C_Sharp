using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents
{
    class TwitterMessagingService : MessagingServiceBase
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine($"¡Enviando Mensaje por Twitter:  {message}");
        }

        public TwitterMessagingService()
        {
            this.ServiceName = "Twitter";
        }
    }
}
