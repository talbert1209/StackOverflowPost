namespace StackOverflowPost
{
    class Program
    {
        static void Main()
        {
            var post = new Post("Can't Make This Work", "I am trying to write some code, but I keep getting errors.");
            
            //post.CreatePost("Can't Make This Work", "I am trying to write some code, but I keep getting errors.");

            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DisplayPost();

        }
    }
}
