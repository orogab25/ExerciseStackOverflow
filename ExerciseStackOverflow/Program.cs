using System;

namespace ExerciseStackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("SQL error","Can't update table",DateTime.Now);
            post.printPost();
            post.UpVote();
            Console.WriteLine("Vote: " + post.Vote);
            post.DownVote();
            Console.WriteLine("Vote: " + post.Vote);
        }
    }
}
