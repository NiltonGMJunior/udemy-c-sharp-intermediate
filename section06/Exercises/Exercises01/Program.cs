using System;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine workflowEngine;
            Video video;
            CloudService cloudService;
            EncodingService encodingService;
            Message message;
            Database database;

            video = new Video();
            cloudService = new CloudService();
            var videoUpload = new VideoUploadActivity(video, cloudService);

            encodingService = new EncodingService();
            var prepareForEncoding = new PrepareForEncodingActivity(video, encodingService);

            message = new Message();
            var sendEmail = new SendEmailActivity(video, message);

            database = new Database();
            var changeDatabase = new ChangeDatabaseActivity(video, database);

            workflowEngine = new WorkflowEngine();
            workflowEngine.RegisterActivity(videoUpload);
            workflowEngine.RegisterActivity(prepareForEncoding);
            workflowEngine.RegisterActivity(sendEmail);
            workflowEngine.RegisterActivity(changeDatabase);

            workflowEngine.Run();
        }
    }
}
