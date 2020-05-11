using System;
using System.Collections.Generic;
using System.Linq;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Enums;
using Fundigent.Blog.CoreObjects.Interfaces;
using Fundigent.Blog.CoreObjects.Models;
using Fundigent.Blog.CoreObjects.ResourceParameters;
using Fundigent.Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Fundigent.Blog.Business.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly FundigentDbContext context;

        public PostRepository(FundigentDbContext context)
        {
            this.context = context;
        }
        public void Add(Post post)
        {
            post.Id = new Guid();
            context.Posts.Add(post);
        }

        public void Delete(Post post)
        {
            if (post == null)
                throw new ArgumentNullException(nameof(post));

            context.Posts.Remove(post);
        }

        public Post Get(Guid id)
        {
            return context.Posts.Include(p => p.Comments).ThenInclude(p => p.User).Include(p => p.Images).OrderByDescending(p => p.CreatedDate).FirstOrDefault(p => p.Id == id);
        }

        public PagedList<Post> Get(PostsResourceParameter resourceParameter)
        {
            var posts = context.Posts
              .OrderByDescending(p => p.CreatedDate)
              .Include(p => p.Comments)
              .ThenInclude(p => p.User)
              .Include(p => p.Images) as IQueryable<Post>;

            if (!string.IsNullOrEmpty(resourceParameter.BlogCategory))
            {
                posts = posts.Where(p => p.BlogCategory == (int)Enum.Parse(typeof(BlogCategory), resourceParameter.BlogCategory, true));
            }

            return PagedList<Post>.Create(posts, resourceParameter.PageNumber, resourceParameter.PageSize);
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() >= 1;
        }

        public void Update(Post item)
        {
            throw new NotImplementedException();
        }
    }
}
