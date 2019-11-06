using System;

namespace Exercises01
{
    public class ChangeDatabaseActivity : IActivity
    {
        private readonly Video _video;
        private readonly Database _database;

        public ChangeDatabaseActivity(Video video, Database database)
        {
            _video = video;
            _database = database;
        }

        public void Execute()
        {
            //  Update database...
            Console.WriteLine("Updating database status...");
        }
    }
}