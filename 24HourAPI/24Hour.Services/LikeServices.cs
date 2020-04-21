using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class LikeServices
    {
        private readonly int _likeId;
        public LikeServices(int likeId)
        {
            _likeId = likeId;
        }
        public bool CreateLike(LikeCreate model)
        {
            var entity =
                new Like()
                {
                    LikeId = _likeId,
                    LikedPost = model.LikedPost,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<LikeListItem> GetLike()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Likes
                    .Where(e => e.LikeId == _likeId)
                    .Select(
                        e =>
                        new LikeListItem
                        {
                            LikeId = e.LikeId,

                            Liker = e.Liker,

                            LikedPost = e.LikedPost,
                        }
                        );
                return query.ToArray();
            }
        }
    }
}
