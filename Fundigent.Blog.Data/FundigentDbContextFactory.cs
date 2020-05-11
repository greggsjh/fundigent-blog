using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Fundigent.Blog.Data
{
    public class FundigentDbContextFactory : IDesignTimeDbContextFactory<FundigentDbContext>
    {
        public FundigentDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddUserSecrets(Assembly.GetExecutingAssembly(), true, false)
            .AddEnvironmentVariables()
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<FundigentDbContext>();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings__FundigentBlogDb"]);
            return new FundigentDbContext(optionsBuilder.Options);
        }
    }
}
