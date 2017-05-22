using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow
{   
    public class Post
    {
        private string _title;
        public string Title { get { return _title; } }
        private string _description;
        public string Description { get { return _description; } }
        private DateTime _createdAt;
        public DateTime CreatedAt { get { return _createdAt; } }
        private int _vote = 0;
        public int Vote
        {
            get
            {
                return this._vote;
            }
        }

        public Post(string title)
        {
            this._title = title;
            this._createdAt = DateTime.Now;
        }

        public Post(string title, string description)
            : this(title)
        {
            this._description = description;
        }

        public void upVote()
        {
            _vote++;
        }

        public void downVote()
        {
            _vote--;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Advanced course in C#");
            var post2 = new Post("C++ question about pointers", "This is a stupid question but I'm beginner");
            for(var i = 0; i < 100; i++)
            {
                post.upVote();
            }
            post.downVote();
            Console.WriteLine("The post '{0}' created at {1} is rated by {2} votes ", post.Title, post.CreatedAt, post.Vote);
        }
    }
}
