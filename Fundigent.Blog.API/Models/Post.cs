using System;

namespace Fundigent.Blog.Models
{
    public class Post
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

