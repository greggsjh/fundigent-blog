using System;

namespace Fundigent.Blog.CoreObjects.Models
{
    /// <summary>
    ///
    /// </summary>
    public class AuthenticationDto
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
        public string UserName { get; set; }
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public string Password { get; set; }
    }
}
