using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class UserServices
    {
        private readonly Guid _userId;
        public UserServices(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateUser(UserCreate model)
        {
            var entity =
                new User()
                {
                    OwnerId = _userId,
                    Name = model.Name,
                    Email = model.Email
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.User.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
