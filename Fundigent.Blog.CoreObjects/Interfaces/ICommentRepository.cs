using System;
using System.Collections.Generic;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.ResourceParameters;

namespace Fundigent.Blog.CoreObjects.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    public interface ICommentRepository
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        void Add(Comment item);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Comment Get(Guid id);
        /// <summary>
        ///
        /// </summary>
        /// <param name="take"></param>
        /// <returns></returns>
        IEnumerable<Comment> Get(int take);
        /// <summary>
        ///
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        IEnumerable<Comment> GetByPostId(Guid postId, CommentsResourceParameter resourceParameter);
        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        void Update(Comment item);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);
        /// <summary>
        ///
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="resourceParameter"></param>
        /// <returns></returns>
        IEnumerable<Comment> GetByUserName(string userName, CommentsResourceParameter resourceParameter);
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
    }
}
