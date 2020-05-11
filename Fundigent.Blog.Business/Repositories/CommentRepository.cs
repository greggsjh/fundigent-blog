using System;
using System.Collections.Generic;
using System.Linq;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Interfaces;
using Fundigent.Blog.CoreObjects.ResourceParameters;
using Fundigent.Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Fundigent.Blog.Business.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly FundigentDbContext context;

        public CommentRepository(FundigentDbContext context)
        {
            this.context = context;
        }

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
            return context.Comments.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Comment> Get(int take)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetByUserName(string userName, CommentsResourceParameter resourceParameter)
        {
            var comments = context.Comments
            .Where(c => c.User.UserName == userName)
            .OrderByDescending(c => c.CreatedDate)
            .Skip((resourceParameter.PageNumber - 1) * resourceParameter.PageSize)
            .Take(resourceParameter.PageSize)
            .Include(c => c.User);

            return comments;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment item)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Comment> ICommentRepository.GetByPostId(Guid postId, CommentsResourceParameter resourceParameter)
        {
            var comments = context.Comments
            .Where(c => c.PostId == postId)
            .OrderByDescending(c => c.CreatedDate)
            .Skip((resourceParameter.PageNumber - 1) * resourceParameter.PageSize)
            .Take(resourceParameter.PageSize)
            .Include(c => c.User);

            return comments;
        }
    }
}
