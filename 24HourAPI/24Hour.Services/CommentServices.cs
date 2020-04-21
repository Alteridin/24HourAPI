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
        private readonly int _commentId;
        public CommentServices(int commentId)
        {
            _commentId = commentId;
        }
        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    CommentId = _commentId,
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
                    .Where(e => e.CommentId == _commentId)
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
