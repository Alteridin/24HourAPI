using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class CommentServices
    {
        private readonly int _CommentId;
        public CommentServices(int commentId)
        {
            _CommentId = commentId;
        }
        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    CommentId = _CommentId,
                    CommentPost = model.CommentPost,
                    Text = model.Text
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CommentListItem> GetComment()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Comments
                    .Where(e => e.CommentId == _CommentId)
                    .Select(
                        e =>
                        new CommentListItem
                        {
                            CommentId = e.CommentId,

                            CommentPost = e.CommentPost,

                            Text = e.Text,

                            Author = e.Author
                        }
                        );
                return query.ToArray();
            }
        }

    }
}
