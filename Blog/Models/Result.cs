using System.Collections.Generic;

namespace Blog.Models
{
    public class Result
    {
        public Post post { get; set; }
        public List<Comment> comments { get; set; }
    }
}