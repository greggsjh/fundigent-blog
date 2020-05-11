using Fundigent.Blog.CoreObjects.Interfaces;

namespace Fundigent.Blog.Business.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
