using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        
        private readonly MongodbService _dbservice;
        public BlogController(MongodbService dbservice)
        {
            _dbservice = dbservice;
        }


        /// <summary>
        /// Gets All The Blog Posts.
        /// </summary>
        [HttpGet]
        public ActionResult<List<Post>> Posts() =>
            _dbservice.GetPosts();

        /// <summary>
        /// Get A Specific Blog Post.
        /// </summary>
        [HttpGet("{id:length(24)}", Name = "GetPost")]
        public ActionResult<Result> Get(string id)
        {
            var post = _dbservice.GetPost(id);
            var coms = _dbservice.GetComments(post.Id);
            if (post == null)
            {
                return NotFound();
            }

            return new Result(){post = post,comments=coms};
        }

        [HttpPost]
        public ActionResult<Post> NewPost(Post post)
        {
            _dbservice.CreatePost(post);

            return Ok();
        }

        [HttpPost("{id:length(24)}")]
        public ActionResult<Post> NewComment(string id,Comment comment)
        {
            comment.PostID = id;
            _dbservice.AddComment(comment);

            return Ok();
        }


        [HttpPut("{id:length(24)}")]
        public IActionResult UpdatePost(string id, Post postIn)
        {
            var post = _dbservice.GetPost(id);

            if (post == null)
            {
                return NotFound();
            }

            _dbservice.UpdatePost(id, postIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var post = _dbservice.GetPost(id);

            if (post == null)
            {
                return NotFound();
            }

            _dbservice.RemovePost(post.Id);
            _dbservice.RemoveComments(post.Id);


            return NoContent();
        }

        [HttpPut("Comment/{id:length(24)}")]
        public IActionResult UpdateComment(string id, Comment commIn)
        {
            var comment = _dbservice.GetComment(id);

            if (comment == null)
            {
                return NotFound();
            }

            _dbservice.UpdateComment(id, commIn);

            return NoContent();
        }

        [HttpDelete("Comment/{id:length(24)}")]
        public IActionResult DeleteComment(string id)
        {
            var comm = _dbservice.GetComment(id);

            if (comm == null)
            {
                return NotFound();
            }

            _dbservice.RemoveComment(comm.Id);


            return NoContent();
        }
    }
}