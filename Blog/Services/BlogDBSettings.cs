namespace Blog.Services
{
    public class BlogDBSettings : IBlogDBSettings
    {
        public string PostCollectionName { get; set; }
        public string CommentCollectionName { get; set; }
        public string UserCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBlogDBSettings
    {
        string PostCollectionName { get; set; }
        string CommentCollectionName { get; set; }
        string UserCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}