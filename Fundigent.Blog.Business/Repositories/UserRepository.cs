using System;
using System.Collections.Generic;
using System.Linq;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Interfaces;
using Fundigent.Blog.Data;

namespace Fundigent.Blog.Business.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FundigentDbContext context;

        public UserRepository(FundigentDbContext context)
        {
            this.context = context;
        }

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get(int take)
        {
            throw new NotImplementedException();
        }

        public User Get(string userName)
        {
            return context.Users.FirstOrDefault(u => u.UserName == userName);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
