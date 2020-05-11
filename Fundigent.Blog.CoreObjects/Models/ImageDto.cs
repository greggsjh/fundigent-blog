using System;

namespace Fundigent.Blog.CoreObjects.Models
{
    /// <summary>
    ///
    /// </summary>
    public class ImageDto
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
        public string Src { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public string Alt { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public int Width { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public int Height { get; set; }
    }
}
