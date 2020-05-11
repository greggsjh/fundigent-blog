using System;
using System.Collections.Generic;

namespace Fundigent.Blog.CoreObjects.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T>
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
    }
}
