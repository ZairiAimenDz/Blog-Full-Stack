namespace BlogClient.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public string AuthorID { get; set; }
        public int Likes { get; set; }
    }
}