using System;
using System.Collections.Generic;
using Fundigent.Blog.CoreObjects.Entities;

namespace Fundigent.Blog.CoreObjects.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        void Add(User item);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User Get(Guid id);
        /// <summary>
        ///
        /// </summary>
        /// <param name="take"></param>
        /// <returns></returns>
        IEnumerable<User> Get(int take);
        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        void Update(User item);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);
        /// <summary>
        ///
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        User Get(string userName);
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
    }
}
