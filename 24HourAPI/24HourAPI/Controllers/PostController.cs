using _24Hour.Models;
using _24Hour.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24HourAPI.Controllers
{
    public class PostController : ApiController
    {
        private PostServices CreatePostService()
        {
            var userId = int.Parse(User.Identity.GetUserId());
            var postService = new PostServices(userId);
            return postService;
        }
        public IHttpActionResult Get()
        {
            PostServices postService = CreatePostService();
            var posts = postService.GetPost();
            return Ok(posts);
        }
        public IHttpActionResult Post(PostCreate post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePostService();

            if (!service.CreatePost(post))
                return InternalServerError();

            return Ok();
        }
    }
}
