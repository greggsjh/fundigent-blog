using AutoMapper;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Models;

namespace Fundigent.Blog.CoreObjects.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
