using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisherWithEvents
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MessageEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
