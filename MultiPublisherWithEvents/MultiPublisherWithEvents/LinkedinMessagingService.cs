using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents
{
    public class LinkedinMessagingService : MessagingServiceBase
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine($"Enviando Mensaje por Linkedin: {message}");
        }

        public LinkedinMessagingService()
        {
            this.ServiceName = "Linkedin";
        }
    }
}
