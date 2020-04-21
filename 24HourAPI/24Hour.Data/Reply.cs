using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Data
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }
        [Required]
        public Comment ReplyComment { get; set; }
        [Required]
        public string ReplyText { get; set; }
        [Required]
        public User ReplyAuthor { get; set; }
    }
}
