using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MultiPublisherWithEvents
{
    public abstract class MessagingServiceBase : IMessagingService
    {

        private readonly Timer messagesTimer;
        private readonly Random random;

        public string ServiceName { get; protected set; }

        public event MessageReceivedEventHandler MessageReceived;

        public void Dispose()
        {
            messagesTimer.Elapsed -= this.MessagesTimer_Elapsed;
            messagesTimer.Stop();
            messagesTimer.Dispose();
        }

        public abstract void SendMessage(string message);

        private void MessagesTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.MessageReceived?.Invoke(this, new MessageEventArgs($"Mensaje recibido desde {this.ServiceName}!"));
            this.messagesTimer.Interval = random.Next(2000, 5001);
        }

        public MessagingServiceBase()
        {
            random = new Random(DateTime.Now.Millisecond);
            messagesTimer = new Timer { Interval = random.Next(2000, 5001) };
            messagesTimer.Elapsed += MessagesTimer_Elapsed;
            messagesTimer.Start();
        }
    }
}