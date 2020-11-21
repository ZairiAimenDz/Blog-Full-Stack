using Blog.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Services
{
    public class MongodbService
    {

        private readonly IMongoCollection<Post> _posts;
        private readonly IMongoCollection<Comment> _comments;

        public MongodbService(IBlogDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _posts = database.GetCollection<Post>(settings.PostCollectionName);
            _comments = database.GetCollection<Comment>(settings.CommentCollectionName);
        }

        public List<Post> GetPosts() =>
            _posts.Find(post => true).ToList();

        public Post GetPost(string id) =>
            _posts.Find<Post>(post => post.Id == id).FirstOrDefault();

        public Post CreatePost(Post post)
        {
            _posts.InsertOne(post);
            return post;
        }

        public void UpdatePost(string id, Post postIn) =>
            _posts.ReplaceOne(post => post.Id == id, postIn);

        public void RemovePost(Post postIn) =>
            _posts.DeleteOne(post => post.Id == postIn.Id);

        public void RemovePost(string id) => 
            _posts.DeleteOne(post => post.Id == id);


        // Comments
        public List<Comment> GetComments(string id) =>
            _comments.Find(c => c.PostID == id).ToList();

        public Comment GetComment(string id) =>
            _comments.Find<Comment>(c => c.Id == id).FirstOrDefault();

        public Comment AddComment(Comment comment)
        {
            _comments.InsertOne(comment);
            return comment;
        }

        public void UpdateComment(string id, Comment comment) =>
            _comments.ReplaceOne(c => c.Id == id, comment);

        public void RemoveComment(string id) => 
            _comments.DeleteOne(c => c.Id == id);

        public void RemoveComments(string id) => 
            _comments.DeleteMany(c => c.Id == id);

        
    }
}