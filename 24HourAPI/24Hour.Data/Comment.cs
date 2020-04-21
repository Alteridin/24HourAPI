using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public User Author { get; set; }
        [Required]
        public Post CommentPost { get; set; }
        public int ReplyId { get; set; }
        [ForeignKey(nameof(ReplyId))]
        public virtual Reply Reply { get; set; }

    }
}
