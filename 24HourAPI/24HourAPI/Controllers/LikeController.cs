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
    public class LikeController : ApiController
    {
        private LikeServices CreateLikeService()
        {
            var userId = Int32.Parse(User.Identity.GetUserId());
            var likeService = new LikeServices(userId);
            return likeService;
        }
        public IHttpActionResult Like(LikeCreate like)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLikeService();

            if (!service.CreateLike(like))
                return InternalServerError();

            return Ok();
        }
    }
}
