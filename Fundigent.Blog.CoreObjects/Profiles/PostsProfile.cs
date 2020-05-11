using System;
using System.Linq;
using AutoMapper;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Enums;
using Fundigent.Blog.CoreObjects.Models;

namespace Fundigent.Blog.CoreObjects.Profiles
{
    public class PostsProfile : Profile
    {
        public PostsProfile()
        {
            CreateMap<Post, PostDto>()
            .ForMember(d => d.BlogCategory, opt => opt.MapFrom(src => Enum.GetName(typeof(BlogCategory), src.BlogCategory)))
            .ForMember(d => d.Comments, opt => opt.MapFrom(src => src.Comments.OrderByDescending(c => c.CreatedDate)));
            CreateMap<Comment, CommentDto>();
            CreateMap<User, UserDto>();
            CreateMap<Image, ImageDto>();

            CreateMap<CreatePostDto, Post>().ForMember(d => d.BlogCategory, opt => opt.MapFrom(src => (int)Enum.Parse(typeof(BlogCategory), src.BlogCategory)));
        }
    }
}
