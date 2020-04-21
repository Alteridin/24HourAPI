using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class PostServices
    {
        private readonly int _postId;
        public PostServices(int postId)
        {
            _postId = postId;
        }
        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    PostId = _postId,
                    Title = model.Title,
                    Text = model.Text
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PostListItem> GetPost()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Posts
                    .Where(e => e.PostId == _postId)
                    .Select(
                        e =>
                        new PostListItem
                        {
                            PostId = e.PostId,

                            Title = e.Title,

                            Text = e.Text,

                            Author = e.Author
                        }
                        );
                return query.ToArray();
            }
        }
    }
}
