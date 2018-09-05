using System;

namespace StackOverflowPost
{
    partial class Program
    {
        public class Post
        {
            private string _title;
            private string _description;
            private DateTime _dateCreated;
            private int voteValue;

            public void CreatePost(string postTitle, string postDescription)
            {
                _title = postTitle;
                _description = postDescription;
            }
        }
    }
}
