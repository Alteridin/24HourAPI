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
    public class ReplyController : ApiController
    {
        private ReplyServices CreateReplyService()
        {
            var userId = int.Parse(User.Identity.GetUserId());
            var replyService = new ReplyServices(userId);
            return replyService;
        }
        public IHttpActionResult Get()
        {
            ReplyServices replyService = CreateReplyService();
            var replies = replyService.GetReply();
            return Ok(replies);
        }
        public IHttpActionResult Reply(ReplyCreate reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.CreateReply(reply))
                return InternalServerError();

            return Ok();
        }
    }
}
