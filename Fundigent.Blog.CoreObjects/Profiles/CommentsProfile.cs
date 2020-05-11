using AutoMapper;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Models;

namespace Fundigent.Blog.CoreObjects.Profiles
{
    public class CommentsProfile : Profile
    {
        public CommentsProfile()
        {
            CreateMap<Comment, UserCommentDto>();
        }
    }
}
