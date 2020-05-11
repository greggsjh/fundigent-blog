using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Interfaces;
using Fundigent.Blog.CoreObjects.Models;
using Fundigent.Blog.CoreObjects.ResourceParameters;
using Microsoft.AspNetCore.Mvc;

namespace Fundigent.Blog.API.Controllers
{
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IPostRepository postRepo;
        private readonly ICommentRepository commentRepo;
        private readonly IMapper mapper;

        public CommentController(IPostRepository postRepo, ICommentRepository commentRepo, IMapper mapper)
        {
            this.postRepo = postRepo;
            this.commentRepo = commentRepo;
            this.mapper = mapper;
        }
    }
}
