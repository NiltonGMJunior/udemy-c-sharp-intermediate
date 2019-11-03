using System;

namespace Exercises02
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public readonly DateTime Timestamp;
        public int Votes { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            Timestamp = DateTime.Now;
            Votes = 0;
        }

        public void UpVote() => Votes++;

        public void DownVote() => Votes--;

    }
}
