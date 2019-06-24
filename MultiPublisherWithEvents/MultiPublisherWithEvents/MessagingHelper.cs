using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents
{
    public static class MessagingHelper
    {
        public static void SayHelloAllServices(params IMessagingService[] services)
        {
            foreach (var service in services)
            {
                service.SendMessage("¡Hola!");
            }
        }
    }
}
