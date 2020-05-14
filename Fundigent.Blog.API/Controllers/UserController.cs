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
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepo;
        private readonly ICommentRepository commentRepo;
        private readonly IMapper mapper;

        public UserController(IUserRepository userRepo, ICommentRepository commentRepo, IMapper mapper)
        {
            this.userRepo = userRepo;
            this.commentRepo = commentRepo;
            this.mapper = mapper;
        }

        [HttpGet("{userName:alphaNumeric}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public ActionResult<UserDto> GetUser(string userName)
        {
            var user = userRepo.Get(userName);

            if (user == null)
            {
                return NotFound(user);
            }

            return mapper.Map<User, UserDto>(user);
        }

        [HttpGet("{userName:alphaNumeric}/comments")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public ActionResult<IEnumerable<UserCommentDto>> GetComments(string userName, [FromQuery] CommentsResourceParameter resourceParameter)
        {
            var comments = commentRepo.GetByUserName(userName, resourceParameter);

            return mapper.Map<IEnumerable<Comment>, IEnumerable<UserCommentDto>>(comments).ToList();
        }

        [HttpOptions]
        public IActionResult GetUserActions()
        {
            Response.Headers.Add("Allow", "GET");
            return Ok();
        }
    }
}
