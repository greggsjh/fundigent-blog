using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using AutoMapper;
using Fundigent.Blog.API.Helpers;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Enums;
using Fundigent.Blog.CoreObjects.Interfaces;
using Fundigent.Blog.CoreObjects.Models;
using Fundigent.Blog.CoreObjects.ResourceParameters;
using Microsoft.AspNetCore.Mvc;

namespace Fundigent.Blog.API.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository postRepo;
        private readonly ICommentRepository commentRepo;
        private readonly IMapper mapper;

        public PostController(IPostRepository postRepo, ICommentRepository commentRepo, IMapper mapper)
        {
            this.postRepo = postRepo;
            this.commentRepo = commentRepo;
            this.mapper = mapper;
        }

        // GET: api/posts/postId
        [HttpGet("{postId:guid}", Name = "GetPost")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public ActionResult<PostDto> GetPost(Guid postId)
        {
            var post = postRepo.Get(postId);

            return mapper.Map<Post, PostDto>(post);
        }

        // GET: api/posts
        [HttpGet(Name = "GetPosts")]
        [HttpHead]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult GetPosts([FromQuery] PostsResourceParameter resourceParameter)
        {
            //List<Post> posts = await _context.Posts.ToListAsync();
            //var postEntities = postRepo.Get(10);
            var postEntities = postRepo.Get(resourceParameter);

            var paginationMetadata = new
            {
                totalCount = postEntities.TotalCount,
                pageSize = postEntities.PageSize,
                currentPage = postEntities.CurrentPage,
                totalPages = postEntities.TotalPages
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));

            var postDtos = mapper.Map<IEnumerable<PostDto>>(postEntities).Expand();

            var postDtosWithLinks = postDtos.Select(el =>
            {
                var postDictionary = el as IDictionary<string, object>;
                postDictionary.Add("links", CreateLinksForPost((Guid)postDictionary["Id"]));
                return postDictionary;
            });

            var links = CreateLinksForPosts(resourceParameter, postEntities.HasNext, postEntities.HasPrevious);

            return Ok(new { posts = postDtosWithLinks, links });
        }

        // GET: api/posts/postId/comments
        [HttpGet("{postId:guid}/comments", Name = "GetComments")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public ActionResult<IEnumerable<CommentDto>> GetComments(Guid postId, [FromQuery] CommentsResourceParameter resourceParameter)
        {
            var comments = commentRepo.GetByPostId(postId, resourceParameter);

            return mapper.Map<IEnumerable<Comment>, IEnumerable<CommentDto>>(comments).ToList();
        }

        // POST: api/posts
        [HttpPost(Name = "CreatePost")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult CreatePost([FromBody] CreatePostDto post)
        {
            var postEntity = mapper.Map<Post>(post);
            postRepo.Add(postEntity);
            postRepo.SaveChanges();

            var postDto = mapper.Map<PostDto>(postEntity).Expand() as IDictionary<string, object>;
            postDto.Add("links", CreateLinksForPost(postEntity.Id));

            return CreatedAtRoute("GetPost", new { postId = postEntity.Id }, postDto);
        }

        [HttpDelete("{postId:guid}", Name = "DeletePost")]
        public IActionResult DeletePost([FromRoute] Guid postId)
        {
            var post = postRepo.Get(postId);

            if (post == null)
                return NotFound();

            postRepo.Delete(post);
            postRepo.SaveChanges();

            return NoContent();
        }

        [HttpOptions]
        public IActionResult GetPostActions()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS, HEAD, POST, DELETE");
            return Ok();
        }

        #region Private Methods

        private IEnumerable<LinkDto> CreateLinksForPost(Guid postId)
        {
            var links = new List<LinkDto>();

            links.Add(new LinkDto
            {
                Href = Url.Link("GetPost", new { postId }),
                Rel = "self",
                Method = "GET"
            });

            links.Add(new LinkDto
            {
                Href = Url.Link("GetComments", new { postId }),
                Rel = "get_comments_for_post",
                Method = "GET"
            });

            links.Add(new LinkDto
            {
                Href = Url.Link("DeletePost", new { postId }),
                Rel = "delete_post",
                Method = "DELETE"
            });

            return links;
        }

        private IEnumerable<LinkDto> CreateLinksForPosts(PostsResourceParameter resourceParameter, bool hasNext, bool hasPrevious)
        {
            var links = new List<LinkDto>();

            links.Add(new LinkDto
            {
                Href = Url.Link("GetPosts", new { resourceParameter }),
                Rel = "currentPage",
                Method = "GET"
            });

            if (hasNext)
            {
                links.Add(new LinkDto
                {
                    Href = Url.Link("GetPosts", new { PageNumber = resourceParameter.PageNumber + 1, resourceParameter.BlogCategory, resourceParameter.PageSize }),
                    Rel = "nextPage",
                    Method = "GET"
                });
            }

            if (hasPrevious)
            {
                links.Add(new LinkDto
                {
                    Href = Url.Link("GetPosts", new { PageNumber = resourceParameter.PageNumber - 1, resourceParameter.BlogCategory, resourceParameter.PageSize }),
                    Rel = "prevPage",
                    Method = "GET"
                });
            }
            return links;
        }

        #endregion
    }
}
