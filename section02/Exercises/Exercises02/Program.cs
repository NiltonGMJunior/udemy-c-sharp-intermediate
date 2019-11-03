using System;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post;
            string title;
            string description;

            title = "Some random title.";
            description = "Some random description.";
            post = new Post(title, description);
            Console.WriteLine(post.Timestamp);
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Votes);
        }
    }
}
