using System;

namespace Exercises01
{
    public class SendEmailActivity : IActivity
    {
        private readonly Video _video;
        private readonly Message _message;

        public SendEmailActivity(Video video, Message message)
        {
            _video = video;
            _message = message;
        }

        public void Execute()
        {
            //  Send email message...
            Console.WriteLine("Sending email message...");
        }
    }
}