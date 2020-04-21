using _24Hour.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class ReplyListItem
    {
        public Comment ReplyComment { get; set; }
        public string ReplyText { get; set; }
        public User ReplyAuthor { get; set; }
    }
}
