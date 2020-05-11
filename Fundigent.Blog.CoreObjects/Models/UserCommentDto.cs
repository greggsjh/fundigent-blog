using System;

namespace Fundigent.Blog.CoreObjects.Models
{
    /// <summary>
    ///
    /// </summary>
    public class UserCommentDto
    {
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public Guid Id { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public string Text { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public DateTime CreatedDate { get; set; }
    }
}
