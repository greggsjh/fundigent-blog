using System;
using System.Collections.Generic;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Models;
using Fundigent.Blog.CoreObjects.ResourceParameters;

namespace Fundigent.Blog.CoreObjects.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    public interface IPostRepository
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        void Add(Post item);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Post Get(Guid id);
        /// <summary>
        ///
        /// </summary>
        /// <param name="resourceParameter"></param>
        /// <returns></returns>
        PagedList<Post> Get(PostsResourceParameter resourceParameter);
        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        void Update(Post item);
        /// <summary>
        ///
        /// </summary>
        /// <param name="post"></param>
        void Delete(Post post);
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
    }
}
