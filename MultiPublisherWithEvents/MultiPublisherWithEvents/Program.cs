using System;

namespace MultiPublisherWithEvents
{
    class Program
    {
        private static void MessagingService_MessageReceived(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        static void Main(string[] args)
        {
            var twitterMessagingService = new TwitterMessagingService();
            var facebookMessaagingService = new FacebookMessagingService();
            var linkedinMessagingService = new LinkedinMessagingService();

            twitterMessagingService.MessageReceived += MessagingService_MessageReceived;
            linkedinMessagingService.MessageReceived += MessagingService_MessageReceived;
            facebookMessaagingService.MessageReceived += MessagingService_MessageReceived;
            Console.ReadLine();
            twitterMessagingService.MessageReceived += MessagingService_MessageReceived;
            linkedinMessagingService.MessageReceived += MessagingService_MessageReceived;
            facebookMessaagingService.MessageReceived += MessagingService_MessageReceived;

            linkedinMessagingService.Dispose();
            twitterMessagingService.Dispose();
            facebookMessaagingService.Dispose();

            //MessagingHelper.SayHelloAllServices(twitterMessagingService, facebookMesaagingService, linkedinMessagingService);
            //twitterMessagingService.MessageReceived()
        }
    }
}
