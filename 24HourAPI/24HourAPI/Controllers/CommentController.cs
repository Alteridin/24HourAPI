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
    public class CommentController : ApiController
    {
        private CommentServices CreateCommentService()
        {
            var userId = int.Parse(User.Identity.GetUserId());
            var commentService = new CommentServices(userId);
            return commentService;
        }
        public IHttpActionResult Get()
        {
            CommentServices commentService = CreateCommentService();
            var comments = commentService.GetComment();
            return Ok(comments);
        }
        public IHttpActionResult Post(CommentCreate comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(comment))
                return InternalServerError();

            return Ok();
        }
    }
}
