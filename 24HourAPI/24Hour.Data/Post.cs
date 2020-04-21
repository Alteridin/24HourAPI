using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public User Author { get; set; }
        public int CommentId { get; set; }
        [ForeignKey(nameof(CommentId))]
        public virtual Comment Comment { get; set; }
        public int LikeId { get; set; }
        [ForeignKey(nameof(LikeId))]
        public virtual Like Like { get; set; }
    }
}
