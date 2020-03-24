using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseStackOverflow
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Vote { get; private set; }

        public Post()
        {
            Vote = 0;
        }

        public Post(string title, string description, DateTime date):this()
        {
            Title = title;
            Description = description;
            Date = date;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }

        public void printPost()
        {
            Console.WriteLine("Title: "+Title+"\nDescription: "+Description+"\nCreated: "+Date+"\nVote: "+Vote+"\n");
        }
    }
}
