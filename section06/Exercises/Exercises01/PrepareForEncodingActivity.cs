using System;
using System.Net.Http;

namespace Exercises01
{
    public class PrepareForEncodingActivity : IActivity
    {
        private readonly Video _video;
        private readonly EncodingService _encodingService;

        public PrepareForEncodingActivity(Video video, EncodingService encodingService)
        {
            _video = video;
            _encodingService = encodingService;
        }

        public void Execute()
        {
            //  Call web based encoding service to prepare for incoming video enconding...
            Console.WriteLine("Preparing for video encoding...");
        }
    }
}