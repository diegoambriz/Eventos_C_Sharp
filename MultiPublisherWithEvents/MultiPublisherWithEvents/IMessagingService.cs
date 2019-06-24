using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents
{
    public interface IMessagingService
    {
        event MessageReceivedEventHandler MessageReceived;
        void SendMessage(string message);
    }
}
