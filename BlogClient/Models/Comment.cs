namespace BlogClient.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string CommentAuthor { get; set; }
        public string CommentContent { get; set; }
        public string PostID { get; set; }
    }
}