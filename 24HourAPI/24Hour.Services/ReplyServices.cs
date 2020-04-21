using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class ReplyServices
    {
        private readonly int _replyId;
        public ReplyServices(int replyId)
        {
            _replyId = replyId;
        }
        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    ReplyId = _replyId,
                    ReplyComment = model.ReplyComment,
                    ReplyText = model.ReplyText
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ReplyListItem> GetReply()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Replies
                    .Where(e => e.ReplyId == _replyId)
                    .Select(
                        e =>
                        new ReplyListItem
                        {
                            ReplyId = e.ReplyId,

                            ReplyComment = e.ReplyComment,

                            ReplyText = e.ReplyText,

                            ReplyAuthor = e.ReplyAuthor
                        }
                        );
                return query.ToArray();
            }
        }
    }
}
