using System;

namespace Fundigent.Blog.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
    }
}
