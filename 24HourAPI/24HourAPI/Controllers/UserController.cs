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
    public class UserController : ApiController
    {
        private UserServices CreateUserService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var UserService = new UserServices(userId);
            return UserService;
        }
        public IHttpActionResult Users(UserCreate user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateUserService();

            if (!service.CreateUser(user))
                return InternalServerError();

            return Ok();
        }
    }
}
