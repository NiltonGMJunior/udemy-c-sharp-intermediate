using System;

namespace Exercises01
{
    public class VideoUploadActivity : IActivity
    {
        private readonly Video _video;
        private readonly CloudService _cloudService;

        public VideoUploadActivity(Video video, CloudService cloudService)
        {
            _video = video;
            _cloudService = cloudService;
        }

        public void Execute()
        {
            //  Uploads video in a cloud storage...
            Console.WriteLine("Uploading video to cloud storage...");
        }
    }
}