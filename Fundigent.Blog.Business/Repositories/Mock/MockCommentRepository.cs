using System;
using System.Collections.Generic;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Interfaces;
using Fundigent.Blog.CoreObjects.ResourceParameters;

namespace Fundigent.Blog.Business.Repositories
{
    public class MockCommentRepository : ICommentRepository
    {
        public void Add(Comment item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Comment Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> Get(int take)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetByPostId(Guid postId, CommentsResourceParameter resourceParameter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetByUserName(string userName, CommentsResourceParameter resourceParameter)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}
