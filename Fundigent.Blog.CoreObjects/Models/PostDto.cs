using System;
using System.Collections.Generic;
using Fundigent.Blog.CoreObjects.Enums;

namespace Fundigent.Blog.CoreObjects.Models
{
    /// <summary>
    ///
    /// </summary>
    public class PostDto
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
        public string Title { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public string Text { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public string BlogCategory { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public IEnumerable<CommentDto> Comments { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public IEnumerable<ImageDto> Images { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public DateTime ModifiedDate { get; set; }
    }
}
