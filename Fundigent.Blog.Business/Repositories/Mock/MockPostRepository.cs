using System;
using System.Collections.Generic;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Interfaces;
using Fundigent.Blog.CoreObjects.Models;
using Fundigent.Blog.CoreObjects.ResourceParameters;

namespace Fundigent.Blog.Business.Repositories
{
    public class MockPostRepository : IPostRepository
    {
        public void Add(Post item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public Post Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public PagedList<Post> Get(PostsResourceParameter resourceParameter)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Post item)
        {
            throw new NotImplementedException();
        }
    }
}
